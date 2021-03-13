using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Challenge.Lib;

namespace Challenge.Function
{
    public static class Function1
    {
        ///api/Function1?value=xxx
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation($"Function1 triggered by HTTP request: {req.Path}.");
            var param = req.Query["value"];

            if (!int.TryParse(param, out var value))
                return new BadRequestObjectResult($"Not an integer: {param}");

            var result = new Service().Get(value);
            return new JsonResult(new string[] { "result", result });
        }
    }
}
