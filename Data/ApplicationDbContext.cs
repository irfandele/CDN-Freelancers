using Microsoft.EntityFrameworkCore;
using CDNFreelancers.Models;

namespace CDNFreelancers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Skillsets)
                .IsRequired();
        }
    }
} 