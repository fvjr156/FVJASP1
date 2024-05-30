using Microsoft.EntityFrameworkCore;

namespace FVJASP1.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SQLEXPRESS;Database=DB_Store;Integrated Security=True;");
        }
    }
}
