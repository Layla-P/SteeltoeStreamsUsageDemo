using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Steeltoe.Stream.StreamHost;

namespace UsageSender
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await StreamHost
            .CreateDefaultBuilder<UsageGenerator>(args)
            .ConfigureServices(svc => svc.AddHostedService<UsageGenerator>())
            .Build()
            .RunAsync();
        }

    }
}
