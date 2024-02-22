using Microsoft.AspNetCore.Mvc;
using MovieBase.Common;

namespace MovieBase.Api.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMovies")]
    public List<Movie> List()
    {
        var movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Blade Runner", Director = "James Cameron", Released = new DateOnly(1982, 6, 25) },
            new Movie { Id = 2, Title = "Star Wars: Episode IV - A New Hope", Director = "George Lucas", Released = new DateOnly(1977, 5, 25) },
            new Movie { Id = 3, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Released = new DateOnly(1999, 3, 31) },
            new Movie { Id = 4, Title = "Inception", Director = "Christopher Nolan", Released = new DateOnly(2010, 7, 16) },
            new Movie { Id = 5, Title = "2001: A Space Odyssey", Director = "Stanley Kubrick", Released = new DateOnly(1968, 4, 6) },
            new Movie { Id = 6, Title = "Interstellar", Director = "Christopher Nolan", Released = new DateOnly(2014, 11, 7) },
            new Movie { Id = 7, Title = "Guardians of the Galaxy", Director = "James Gunn", Released = new DateOnly(2014, 8, 1) },
            new Movie { Id = 8, Title = "Avatar", Director = "James Cameron", Released = new DateOnly(2009, 12, 18) },
            new Movie { Id = 9, Title = "Arrival", Director = "Denis Villeneuve", Released = new DateOnly(2016, 11, 11) },
            new Movie { Id = 10, Title = "Ender's Game", Director = "Gavin Hood", Released = new DateOnly(2013, 11, 1) }
        };
        return movies;
    }
}
