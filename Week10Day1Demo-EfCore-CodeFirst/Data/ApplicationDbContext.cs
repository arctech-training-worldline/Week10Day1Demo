using Microsoft.EntityFrameworkCore;
using Week10Day1Demo_EfCore_CodeFirst.Models;

namespace Week10Day1Demo_EfCore_CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
