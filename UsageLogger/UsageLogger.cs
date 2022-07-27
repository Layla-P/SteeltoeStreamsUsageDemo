using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Steeltoe.Stream.Attributes;
using Steeltoe.Stream.Messaging;

namespace UsageLogger;

[EnableBinding(typeof(ISink))]
public class UsageLog
{
    private static ILogger<UsageLog> _logger;

    public UsageLog(ILogger<UsageLog> logger)
    {
        _logger = logger ?? NullLogger<UsageLog>.Instance;
    }

    [StreamListener(IProcessor.INPUT)]
    public void Handle(UsageCostDetail costDetail) =>
        _logger.LogInformation("Received UsageCostDetail " + costDetail);

}
