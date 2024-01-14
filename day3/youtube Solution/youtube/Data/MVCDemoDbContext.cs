using Microsoft.EntityFrameworkCore;
using youtube.Models.Domain;

namespace youtube.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        // هذي تربط الداتا
        public DbSet<Employee> Employees { get; set; }
        //class / table in db
       // public DbSet<Employee> Employees { get; set; }

    }
}
