using Authentik.Client.Api;
using AuthentikJellyfinSync.Configuration;
using Jellyfin.Data;
using Jellyfin.Database.Implementations.Entities;
using Jellyfin.Database.Implementations.Enums;
using MediaBrowser.Controller.Library;
using Microsoft.Extensions.Logging;

namespace AuthentikJellyfinSync.Sync;

public class ProviderSyncClient
{
    private readonly ProviderConfig _providerConfig;
    private readonly OidConfigProxy _oidConfig;
    private readonly IUserManager _userManager;
    private readonly ILogger _logger;


    public ProviderSyncClient(ProviderConfig providerConfig, OidConfigProxy oidConfig, IUserManager userManager, ILogger logger)
    {
        _providerConfig = providerConfig;
        _oidConfig = oidConfig;
        _userManager = userManager;
        _logger = logger;
    }

    public async Task SyncUsers()
    {
        var config = new Authentik.Client.Client.Configuration
        {
            BasePath = _providerConfig.AuthentikApiUrl,
            AccessToken = _providerConfig.AuthentikApiToken
        };
        
        using var httpClient = new HttpClient();
        using var httpClientHandler = new HttpClientHandler();
            
        var coreApi = new CoreApi(httpClient, config, httpClientHandler);
                    
        foreach ((var oauthId, var userId) in _oidConfig.CanonicalLinks)
        {
            try
            {
                await SyncUser(coreApi, userId, oauthId);
            }
            catch (Exception e)
            {
                _logger.LogWarning(e, "Failed to sync user {UserId} (oauthId={OauthId})", userId, oauthId);
            }
        }
    }

    private async Task SyncUser(CoreApi api, Guid jellyfinUserId, string oauthUserId)
    {
        var jellyfinUser = _userManager.GetUserById(jellyfinUserId);
        if (jellyfinUser == null) return;
        
        var authentikUser = UserUtilities.GetUser(api, _providerConfig.UserIdentifierType, oauthUserId);
        if (authentikUser == null)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        if (!authentikUser.IsActive)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        bool hasRoleClaimAccess = HasRoleClaimAccess(authentikUser);
        bool authentikUserHasAccess = await HasApplicationAccess(api, authentikUser);

        if (!hasRoleClaimAccess || !authentikUserHasAccess)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        if (!_providerConfig.ReEnableAccount) return;
        
        await SetUserEnabledStatus(jellyfinUser, true);
    }
    
    private async Task SetUserEnabledStatus(User user, bool enabled)
    {
        bool jellyfinUserEnabled = !user.HasPermission(PermissionKind.IsDisabled);
        if (jellyfinUserEnabled == enabled) return;
        
        user.SetPermission(PermissionKind.IsDisabled, !enabled);
        await _userManager.UpdateUserAsync(user);
    }

    private bool HasRoleClaimAccess(Authentik.Client.Model.User authentikUser)
    {
        if (_oidConfig.Roles.Length <= 0) return true; // If no roles are set, the role check is disabled.
        
        foreach (var group in _oidConfig.Roles)
        {
            foreach (var authentikGroup in authentikUser.GroupsObj)
            {
                if (group == authentikGroup.Name)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private async Task<bool> HasApplicationAccess(CoreApi api, Authentik.Client.Model.User authentikUser)
    {
        var applicationList = await api.CoreApplicationsListAsync(forUser: authentikUser.Pk, slug: _providerConfig.ApplicationSlug);
        foreach (var application in applicationList.Results)
        {
            if (application.Slug == _providerConfig.ApplicationSlug)
            {
                return true;
            }
        }

        return false;
    }

    public static async Task SyncTask(IUserManager _userManager, ILogger _logger)
    {
        var cfg = AuthentikJellyfinSync.Instance!.Configuration;

        var oidConfigs = SsoAuthReflection.GetOidConfigs();

        var tasks = new List<Task>();
        foreach (var (id, oidConfig) in oidConfigs)
        {
            var providerConfig = cfg.ProviderConfigs.FirstOrDefault(p => p.Id == id);
            if (providerConfig == null) continue;

            var syncClient = new ProviderSyncClient(providerConfig, oidConfig, _userManager, _logger);
            tasks.Add(syncClient.SyncUsers());
        }

        await Task.WhenAll(tasks);
    }

}