using Microsoft.Extensions.Hosting;

namespace BackgroundTasks.UsingBackgroundService;

public class MyBackgroundTask2 : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        //process here

        return Task.CompletedTask;
    }
}