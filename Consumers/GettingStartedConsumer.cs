namespace GettingStarted.Consumers;

using System.Threading.Tasks;
using MassTransit;
using Contracts;
using Microsoft.Extensions.Logging;


public class GettingStartedConsumer : IConsumer<GettingStarted>
{
    readonly ILogger<GettingStartedConsumer> _logger;

    public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<GettingStarted> context)
    {
        _logger.LogInformation("Received Text: {Text}", context.Message.Value);
        return Task.CompletedTask;
    }
}
