using Microsoft.AspNetCore.Mvc;

namespace Fundamentos.Api.Controllers
{
    [ApiController]
    [Route("api/minha-controller")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
                
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ok");
        }
    }
}