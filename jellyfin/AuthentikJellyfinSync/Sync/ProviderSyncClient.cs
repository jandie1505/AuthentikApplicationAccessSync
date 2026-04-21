using Authentik.Client.Api;
using AuthentikJellyfinSync.Configuration;
using Jellyfin.Data;
using Jellyfin.Database.Implementations.Entities;
using Jellyfin.Database.Implementations.Enums;
using MediaBrowser.Controller.Library;
using Microsoft.Extensions.Logging;

namespace AuthentikJellyfinSync.Sync;

/// <summary>
/// Updates the active status of Jellyfin users to the Authentik user active status and application access.
/// </summary>
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

    /// <summary>
    /// Updates the active status of all Jellyfin users from this provider to the Authentik user active status and application access.
    /// </summary>
    public async Task SyncUsers()
    {
        _logger.LogInformation("Syncing provider {id}...", _providerConfig.Id);
        
        var config = new Authentik.Client.Client.Configuration
        {
            BasePath = _providerConfig.AuthentikApiUrl.TrimEnd('/'),
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
        
        _logger.LogInformation("Finished sync of provider {id}", _providerConfig.Id);
    }

    /// <summary>
    /// Updates the active status of the specified Jellyfin user from this provider to the Authentik user active status and application access.<br/>
    /// The Jellyfin user will be disabled, when the Authentik account does not exist, is disabled, it does not have access to the specified application or (when enabled) does not pass the SSO-Auth plugin role claims.<br/>
    /// The Jellyfin user will be enabled, when none of the conditions above is true, and the config option ReEnableAccount is enabled.
    /// </summary>
    /// <param name="api">The Authentik CoreAPI object.</param>
    /// <param name="jellyfinUserId">The Jellyfin user id.</param>
    /// <param name="oauthUserId">The linked Oauth User Identifier from the SSO-Auth plugin.</param>
    private async Task SyncUser(CoreApi api, Guid jellyfinUserId, string oauthUserId)
    {
        var jellyfinUser = _userManager.GetUserById(jellyfinUserId);
        if (jellyfinUser == null) return;
        
        // Disable account if user does not exist.
        var authentikUser = UserUtilities.GetUser(api, _providerConfig.UserIdentifierType, oauthUserId);
        if (authentikUser == null)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        // Disable account if user is not active.
        if (!authentikUser.IsActive)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        bool hasRoleClaimAccess = HasRoleClaimAccess(authentikUser);
        bool authentikUserHasAccess = await HasApplicationAccess(api, authentikUser);

        // Disable user if the user has no access to the application.
        if (!hasRoleClaimAccess || !authentikUserHasAccess)
        {
            await SetUserEnabledStatus(jellyfinUser, false);
            return;
        }

        // Re-enable account when enabled.
        if (!_providerConfig.ReEnableAccount) return;
        
        await SetUserEnabledStatus(jellyfinUser, true);
    }
    
    /// <summary>
    /// Sets the Jellyfin user enabled status, when the new status is different from the current status.
    /// </summary>
    /// <param name="user">The Jellyfin user.</param>
    /// <param name="enabled">Enable/Disable the user.</param>
    private async Task SetUserEnabledStatus(User user, bool enabled)
    {
        bool jellyfinUserEnabled = !user.HasPermission(PermissionKind.IsDisabled);
        if (jellyfinUserEnabled == enabled) return;
        
        user.SetPermission(PermissionKind.IsDisabled, !enabled);
        await _userManager.UpdateUserAsync(user);
        _logger.LogInformation("Updated user {user_id} (name={name} to enabled={enabled}", user.Id.ToString(), user.Username, enabled);
    }

    /// <summary>
    /// Check if the user has access using a role claim check.<br/>
    /// This is the case if either the user is in any group specified in the role claim of the SSO plugin or the role claim is disabled.
    /// </summary>
    /// <param name="authentikUser">The Authentik user.</param>
    /// <returns>if the user has access.</returns>
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

    /// <summary>
    /// Ask Authentik if a user has access to this application.
    /// </summary>
    /// <param name="api">The CoreAPI object.</param>
    /// <param name="authentikUser">The Authentik user to check for.</param>
    /// <returns>If the user has access to the application.</returns>
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

}