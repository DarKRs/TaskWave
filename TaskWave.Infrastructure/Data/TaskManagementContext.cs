using Microsoft.EntityFrameworkCore;
using TaskWave.Domain.Entities;

namespace TaskWave.Infrastructure.Data
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=TaskManagementDb;Username=postgres;Password=postgres");
        }
    }
}
