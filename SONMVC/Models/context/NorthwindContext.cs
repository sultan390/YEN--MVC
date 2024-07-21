using Microsoft.EntityFrameworkCore;
using SONMVC.Models.entity;

namespace SONMVC.Models.context
{
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=ALPERSULTAN;" +
                "database=csharp215;Trusted_connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 

    }
}
