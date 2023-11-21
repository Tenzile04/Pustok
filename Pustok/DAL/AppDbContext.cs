using Microsoft.EntityFrameworkCore;
using Pustok.Models;


namespace Pustok.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Feature> Features { get; set; }
    }
}
