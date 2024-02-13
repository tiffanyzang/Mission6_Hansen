using Microsoft.EntityFrameworkCore;

namespace Mission6_Hansen.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> MovieCollection { get; set; }
    }

    
}
