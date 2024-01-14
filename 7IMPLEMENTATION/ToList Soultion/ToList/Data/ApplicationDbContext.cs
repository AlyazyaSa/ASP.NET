using Microsoft.EntityFrameworkCore;
using ToList.Models;

namespace ToList.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        //fluent API !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>().Property(w => w.isFinished)
            .HasDefaultValue(false);
        }


        public DbSet<Todo> todos { get; set; }

    }
}
