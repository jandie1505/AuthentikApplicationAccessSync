using MediaBrowser.Model.Plugins;

namespace AuthentikJellyfinSync.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    
    /// <summary>
    /// Provider configurations. ProviderConfig.Id must match the provider name of the SSO-Auth plugin.
    /// Stored as an array because XmlSerializer (used by Jellyfin's plugin config) cannot serialize IDictionary.
    /// </summary>
    public ProviderConfig[] ProviderConfigs { get; set; } = Array.Empty<ProviderConfig>();

}