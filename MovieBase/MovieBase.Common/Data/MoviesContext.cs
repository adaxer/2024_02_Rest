using Microsoft.EntityFrameworkCore;

namespace MovieBase.Common.Data;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
    {
    }
        
    public DbSet<Movie> Movies { get; set; }
}
