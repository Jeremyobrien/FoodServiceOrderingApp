using Microsoft.EntityFrameworkCore;

namespace FoodServiceOrderingApp.Models
{
    public class FoodServiceOrderingAppDbContext : DbContext
    {
        public FoodServiceOrderingAppDbContext(DbContextOptions<FoodServiceOrderingAppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
    }
}
