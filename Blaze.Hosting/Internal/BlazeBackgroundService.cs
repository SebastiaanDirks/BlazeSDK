using Blaze.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Channels;

namespace Blaze.Hosting.Internal;

public class BlazeBackgroundService : BackgroundService
{
    Channel<Func<CancellationToken, Task>> _serverChannel = Channel.CreateUnbounded<Func<CancellationToken, Task>>();
    IList<Task> tasks = new List<Task>();
    ILogger<BlazeBackgroundService> _logger;
    IServiceProvider _provider;


    public BlazeBackgroundService(ILogger<BlazeBackgroundService> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _provider = serviceProvider;


        IEnumerable<BlazeServerContext> blazeServerContexts = _provider.GetServices<BlazeServerContext>().Distinct();
        foreach (BlazeServerContext blazeServerContext in blazeServerContexts)
            blazeServerContext.Initialize(_provider, this);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Blaze Background Service is running.");

        while (!stoppingToken.IsCancellationRequested)
        {
            Task<Func<CancellationToken, Task>> dequeueTask = _serverChannel.Reader.ReadAsync(stoppingToken).AsTask();
            IEnumerable<Task> allTasks = tasks.Concat([dequeueTask]);

            try
            {
                Task finishedTask = await Task.WhenAny(allTasks).ConfigureAwait(false);

                if (finishedTask == dequeueTask)
                {
                    Func<CancellationToken, Task> startServer = await dequeueTask.ConfigureAwait(false);
                    Task newServerTask = startServer(stoppingToken);
                    tasks.Add(newServerTask);
                }
                else
                {
                    tasks.Remove(finishedTask); // remove the finished task
                    await finishedTask.ConfigureAwait(false); // await the finished task which may throw an exception
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while executing a background task.");
            }
        }

        _logger.LogInformation("Blaze Background Service has stopped.");
    }

    public void AddBlazeServer(BlazeServer server)
    {
        _serverChannel.Writer.TryWrite(ct => server.StartAsync(ct));
    }

    public void AddRestServer(BlazeRestServer server)
    {
        _serverChannel.Writer.TryWrite(ct => server.StartAsync(ct));
    }
}
