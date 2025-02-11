using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForcastServices _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcastServices service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _service.Get();
            return result;
        }
        [HttpGet]
        [Route("currentDay/{max}")]
        public IEnumerable<WeatherForecast> Get2([FromQuery] int take, [FromRoute] int max)
        {
            var result = _service.Get();
            return result;
        }
        [HttpGet("monday")]
        public IEnumerable<WeatherForecast> Get3()
        {
            var result = _service.Get();
            return result;
        }
        [HttpPost]
        public ActionResult<string> Hello([FromBody] string name)
        {
            return StatusCode(401, $"Hello {name}");
        }
        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Generate([FromQuery] int result, [FromBody] TemperatureReq request)
        {
            if (result <0 || request.Max < request.Min)
            {
                return BadRequest();
            }

            var res = _service.Get(result, request.Min, request.Max);
            return Ok(res);
        }
    }
}
