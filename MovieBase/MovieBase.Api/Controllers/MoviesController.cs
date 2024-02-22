using Microsoft.AspNetCore.Mvc;

namespace MovieBase.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMovies")]
    public string Get()
    {
        return "Movies works";
    }
}
