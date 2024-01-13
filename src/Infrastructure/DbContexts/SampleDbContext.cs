using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.DbContexts
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options) { }

        public DbSet<Education> Educations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seed
            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = Guid.NewGuid(),
                    Degree = "Bachelor's degree",
                    FieldOfStudy = "Software engineering",
                    School = "Sample university"
                }
                );
        }
    }
}