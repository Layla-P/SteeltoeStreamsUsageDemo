using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Steeltoe.Stream.StreamHost;
using UsageSender;

await StreamHost
            .CreateDefaultBuilder<UsageGenerator>(args)
            .ConfigureServices(svc => svc.AddHostedService<UsageGenerator>())
            .Build()
            .RunAsync();
    