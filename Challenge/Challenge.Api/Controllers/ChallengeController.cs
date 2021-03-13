using Challenge.Lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChallengeController : ControllerBase
    {
        private readonly ILogger<ChallengeController> _logger;

        public ChallengeController(ILogger<ChallengeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{value}")]
        public IActionResult Get([FromRoute] int value) => new JsonResult(new string[] { "result", new Service().Get(value) });
    }
}
