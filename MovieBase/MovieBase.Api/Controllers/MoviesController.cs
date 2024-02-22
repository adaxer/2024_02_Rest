using Microsoft.AspNetCore.Mvc;
using MovieBase.Common;
using System.Reflection;

namespace MovieBase.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private readonly MovieService _movieService;

    public MoviesController(ILogger<MoviesController> logger, MovieService movieService)
    {
        _logger = logger;
        _movieService = movieService;
    }

    [HttpGet(Name = "GetMovies")]
    public async Task<IActionResult> List()
    {
        var result = await _movieService.GetMovies();
        return Ok(result);
    }

    //public async void ButtonClick(object sender, EventArgs e)
    //{
    //    Products = await DataService.GetProducts();
    //    List.Items = Products;
    //}

    //public  IActionResult List()
    //{
    //    var result = _movieService.GetMovies();
    //    return Ok(result);
    //}

    [HttpGet("{id}", Name = "Details")]
    public IActionResult Details(int id)
    {
        var result = _movieService.FindMovie(id);
        return (result == null)
            ? NotFound()
            : Ok(result);
    }

    [HttpPost(Name = "CreateMovie")]
    public IActionResult Create([FromBody] Movie movie)
    {
        _movieService.SaveMovie(movie);
        return CreatedAtAction("Details", new { id=movie.Id }, movie);
    }
}
