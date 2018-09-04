using AzureFunctionV2DI;
using AzureFunctionV2DI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Logging;

[assembly: WebJobsStartup(typeof(Startup))]

namespace AzureFunctionV2DI
{
    public static class TestFunction
    {
        [FunctionName("Test")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]
            HttpRequest req,
            ILogger log,
            [Inject(typeof(ITestService))]ITestService testService
        )
        {
            return new AcceptedResult();
        }
    }
}
