using AuthentikJellyfinSync.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace AuthentikJellyfinSync;

public class AuthentikJellyfinSync : BasePlugin<PluginConfiguration>
{
    public override string Name => "AuthentikJellyfinSync";
    public override Guid Id => Guid.Parse("2da33357-06b7-4f2f-8c8e-7d3fce5bf03c");

    public AuthentikJellyfinSync(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }
    
    public static AuthentikJellyfinSync? Instance { get; private set; }
    
}
