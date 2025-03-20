using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController()
    {

    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
