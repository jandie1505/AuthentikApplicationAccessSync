using AuthentikJellyfinSync.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace AuthentikJellyfinSync;

public class AuthentikJellyfinSync : BasePlugin<PluginConfiguration>
{

    public AuthentikJellyfinSync(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
    {
        
    }
    
    public override string Name => throw new System.NotImplementedException();
    
    public override Guid Id => Guid.Parse("");
    
}
