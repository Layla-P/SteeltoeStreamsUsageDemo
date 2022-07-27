using Microsoft.Extensions.Hosting;
using Steeltoe.Stream.StreamHost;
using UsageProcessor;

await StreamHost.CreateDefaultBuilder<UsageProcess>(args)
            .RunConsoleAsync();
 