namespace AuthentikJellyfinSync.Configuration;

public class ProviderConfig
{
    /// <summary>
    /// Provider id. Must exactly match the provider name of the SSO-Auth plugin.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    public string AuthentikApiUrl { get; set; } = string.Empty;
    public string AuthentikApiToken { get; set; } = string.Empty;
    public UserIdentifierType UserIdentifierType { get; set; } = UserIdentifierType.Pk;
    public string CustomSubClaim { get; set; } = string.Empty;
    public string ApplicationSlug { get; set; } = string.Empty;
    public bool ReEnableAccount { get; set; } = true;
    public bool AutoSyncEnabled { get; set; } = false;
}

public enum UserIdentifierType
{
    Pk,
    Uuid,
    Email,
    Username,
    Custom
}