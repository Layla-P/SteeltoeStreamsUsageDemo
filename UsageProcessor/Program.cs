using Microsoft.Extensions.Hosting;
using Steeltoe.Stream.StreamHost;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace UsageProcessor
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            await StreamHost.CreateDefaultBuilder<UsageProcessor>(args)
            .RunConsoleAsync();
        }
    }
}
