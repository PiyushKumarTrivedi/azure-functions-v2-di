using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

namespace AzureFunctionV2DI
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<InjectConfiguration>();
        }
    }
}