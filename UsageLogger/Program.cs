using Microsoft.Extensions.Hosting;
using Steeltoe.Stream.StreamHost;
using UsageLogger;


await StreamHost.CreateDefaultBuilder<UsageLog>(args)
      .RunConsoleAsync();
