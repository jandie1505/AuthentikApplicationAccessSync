using MediaBrowser.Controller.Library;
using MediaBrowser.Model.Tasks;
using Microsoft.Extensions.Logging;

namespace AuthentikJellyfinSync.Sync;

public class SyncTask : IScheduledTask
{
    private readonly ILogger<SyncTask> _logger;
    private readonly IUserManager _userManager;
    private static int _running;

    public SyncTask(ILogger<SyncTask> logger, IUserManager userManager)
    {
        _logger = logger;
        _userManager = userManager;
    }
    
    public async Task ExecuteAsync(IProgress<double> progress, CancellationToken cancellationToken)
    {
        if (Interlocked.CompareExchange(ref _running, 1, 0) != 0)
        {
            _logger.LogWarning("Sync task already running. Skipping.");
            return;
        }

        try
        {
            progress.Report(0);
            
            var cfg = AuthentikJellyfinSync.Instance!.Configuration;

            if (!SsoAuthReflection.IsAvailable)
            {
                _logger.LogWarning("SSO-Auth plugin is not loaded. Skipping sync.");
                return;
            }

            _logger.LogInformation("Starting sync...");
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
            _logger.LogInformation("Sync finished.");
            progress.Report(100);
        }
        finally
        {
            Interlocked.Exchange(ref _running, 0);
        }
        
    }

    public IEnumerable<TaskTriggerInfo> GetDefaultTriggers() =>
    [
        new TaskTriggerInfo()
        {
            Type = TaskTriggerInfoType.DailyTrigger,
            TimeOfDayTicks = TimeSpan.FromDays(1).Ticks
        }
    ];

    public string Name => "Authentik Sync";
    public string Key => "AuthentikJellyfinSync";
    public string Description => "Synchronizes the account activation status with Authentik.";
    public string Category => "Authentik";
}