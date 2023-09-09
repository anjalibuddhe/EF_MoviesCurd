using Microsoft.EntityFrameworkCore;


namespace EF_MoviesCurd.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Movie>  Movies{ get; set; }
    }
}
