using System.Collections;
using System.Reflection;

namespace AuthentikJellyfinSync.Sync;

/// <summary>
/// Reflection-based bridge to the Jellyfin SSO-Auth plugin.
/// Avoids a compile-time assembly reference so this plugin can be loaded
/// by Jellyfin even when SSO-Auth has not been resolved yet.
/// </summary>
public static class SsoAuthReflection
{
    private const string SsoPluginTypeName = "Jellyfin.Plugin.SSO_Auth.SSOPlugin";

    private static Type? FindSsoPluginType()
    {
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            Type? type;
            try
            {
                type = asm.GetType(SsoPluginTypeName, throwOnError: false);
            }
            catch
            {
                continue;
            }
            if (type != null) return type;
        }
        return null;
    }

    public static bool IsAvailable => FindSsoPluginType() != null;

    public static IReadOnlyDictionary<string, OidConfigProxy> GetOidConfigs()
    {
        var pluginType = FindSsoPluginType()
            ?? throw new InvalidOperationException($"Type '{SsoPluginTypeName}' not found in any loaded assembly.");

        var instance = pluginType
            .GetProperty("Instance", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            ?.GetValue(null)
            ?? throw new InvalidOperationException("SSOPlugin.Instance is null or missing.");

        var configuration = instance.GetType()
            .GetProperty("Configuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
            ?.GetValue(instance)
            ?? throw new InvalidOperationException("SSOPlugin.Configuration is null or missing.");

        var oidConfigsRaw = configuration.GetType()
            .GetProperty("OidConfigs", BindingFlags.Public | BindingFlags.Instance)
            ?.GetValue(configuration)
            ?? throw new InvalidOperationException("PluginConfiguration.OidConfigs is null or missing.");

        var result = new Dictionary<string, OidConfigProxy>();
        if (oidConfigsRaw is IDictionary dict)
        {
            foreach (DictionaryEntry entry in dict)
            {
                if (entry.Key is not string key || entry.Value is null) continue;
                result[key] = new OidConfigProxy(entry.Value);
            }
        }
        return result;
    }
}

/// <summary>Reflection wrapper around SSO-Auth's OidConfig.</summary>
public sealed class OidConfigProxy
{
    private readonly object _inner;

    public OidConfigProxy(object inner) => _inner = inner;

    public IReadOnlyDictionary<string, Guid> CanonicalLinks
    {
        get
        {
            var raw = _inner.GetType()
                .GetProperty("CanonicalLinks", BindingFlags.Public | BindingFlags.Instance)
                ?.GetValue(_inner);

            var result = new Dictionary<string, Guid>();
            if (raw is IDictionary dict)
            {
                foreach (DictionaryEntry entry in dict)
                {
                    if (entry.Key is not string key) continue;
                    if (entry.Value is Guid guid)
                    {
                        result[key] = guid;
                    }
                    else if (entry.Value != null && Guid.TryParse(entry.Value.ToString(), out var parsed))
                    {
                        result[key] = parsed;
                    }
                }
            }
            return result;
        }
    }

    public string[] Roles
    {
        get
        {
            var raw = _inner.GetType()
                .GetProperty("Roles", BindingFlags.Public | BindingFlags.Instance)
                ?.GetValue(_inner);

            return raw switch
            {
                string[] arr => arr,
                IEnumerable<string> seq => seq.ToArray(),
                IEnumerable objs => objs.Cast<object?>().Select(o => o?.ToString() ?? string.Empty).ToArray(),
                _ => Array.Empty<string>()
            };
        }
    }
}