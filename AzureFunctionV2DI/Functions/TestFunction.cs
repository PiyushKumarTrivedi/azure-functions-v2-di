using AzureFunctionV2DI.Extensions;
using AzureFunctionV2DI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace AzureFunctionV2DI.Functions
{
    public static class TestFunction
    {
        [FunctionName("Test")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]
            HttpRequest req,
            [Inject(typeof(ITestService))]ITestService testService
        )
        {
            return new AcceptedResult();
        }
    }
}
