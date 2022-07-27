using Microsoft.Extensions.Hosting;
using Steeltoe.Stream.StreamHost;
using System.Threading.Tasks;


namespace UsageLogger
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            await StreamHost.CreateDefaultBuilder<UsageLogger>(args)
                  .RunConsoleAsync();
        }
    }
}
