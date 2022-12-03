using Microsoft.Extensions.Hosting;
namespace BackgroundTasks.UsingHostedService;

public class MyBackgroundTask :  IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        // implement process
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        // implement clean up 
        return Task.CompletedTask;
    }
}