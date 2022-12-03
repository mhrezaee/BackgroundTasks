using Microsoft.Extensions.Hosting;
namespace BackgroundTasks.UsingHostedService;

public class MyBackgroundTask :  IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        // implement process
        return null;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        // implement clean up 
        return null;
    }
}