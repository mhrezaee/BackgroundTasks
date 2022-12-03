using Microsoft.Extensions.Hosting;

namespace BackgroundTasks.UsingBackgroundService;

public class MyPeriodicBackgroundTask : BackgroundService
{
    private readonly TimeSpan _period = TimeSpan.FromMinutes(10);
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using PeriodicTimer timer = new PeriodicTimer(_period);

        while (!stoppingToken.IsCancellationRequested &&
               await timer.WaitForNextTickAsync(stoppingToken))
        {
            //process here
        }

        return;
    }
}