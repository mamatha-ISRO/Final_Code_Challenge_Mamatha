using Microsoft.EntityFrameworkCore;

namespace LaunchpadCodeChallenge.API.Models
{
    public class EmployeeManagerContext : DbContext
    {
        public EmployeeManagerContext(DbContextOptions<EmployeeManagerContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Employees)
                .WithOne(a => a.Departments)
                .HasForeignKey(e => e.DepartmentId);
            
            modelBuilder.Seed();
        }

        public DbSet<Employees> Employee { get; set; }
        public DbSet<Departments> Department { get; set; }
    }
   
}
