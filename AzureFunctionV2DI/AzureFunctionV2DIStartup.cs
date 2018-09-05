using AzureFunctionV2DI;
using AzureFunctionV2DI.Extensions;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(AzureFunctionV2DiStartup))]

namespace AzureFunctionV2DI
{
    public class AzureFunctionV2DiStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<InjectConfiguration>();
        }
    }
}