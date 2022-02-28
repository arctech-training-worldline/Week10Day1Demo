using Microsoft.EntityFrameworkCore;
using Week10Day1Demo_EfCore.Models;

namespace Week10Day1Demo_EfCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
