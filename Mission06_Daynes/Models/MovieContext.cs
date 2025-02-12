using Microsoft.EntityFrameworkCore;

namespace Mission06_Daynes.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) // Constructor
        {
        }

        public DbSet<AddMovie> Movies { get; set; }
    }
}
