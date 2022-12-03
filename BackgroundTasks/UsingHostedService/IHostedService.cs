namespace BackgroundTasks.UsingHostedService;

public interface IHostedService
{
    Task StartAsync(CancellationToken cancellationToken);

    Task StopAsync(CancellationToken cancellationToken);
}