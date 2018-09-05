using AzureFunctionV2DIExtensions;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(AzureFunctionV2DiStartup))]

namespace AzureFunctionV2DIExtensions
{
    public class AzureFunctionV2DiStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<InjectConfiguration>();
        }
    }
}