using DealJunctions.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DealJunctions.Repository.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
          base(options)
        { }

        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<Promotion> Promotions { get; set; } = null!;
        public DbSet<PromotionStatistic> PromotionStatistics { get; set; } = null!;
        public DbSet<Subscription> Subscriptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany()
                .HasForeignKey(e => e.CompanyId);
        }
    }
}
