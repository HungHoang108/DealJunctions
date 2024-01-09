using DealJunctions.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DealJunctions.Repository.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
          base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(s => s.Subscription)
                .WithMany()
                .HasForeignKey(s => s.SubscriptionId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PromotionStatistic>()
                .HasOne(p => p.Promotion)
                .WithMany()
                .HasForeignKey(p => p.PromotionId);


            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(p => p.Promotion).WithMany().HasForeignKey(p => p.PromotionId).IsRequired();
                entity.HasOne(p => p.Company).WithMany().HasForeignKey(p => p.CompanyId).IsRequired();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.PhoneNumber).IsUnique();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.HasMany(e => e.Employees).WithOne(e => e.Company).HasForeignKey(e => e.CompanyId).OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(e => e.Promotions).WithOne(e => e.Company).HasForeignKey(e => e.CompanyId).OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Subscription>().Property(x => x.Price).HasPrecision(7, 2);

            modelBuilder.Entity<Company>().Navigation(item => item.Employees).AutoInclude();
            modelBuilder.Entity<Company>().Navigation(item => item.Promotions).AutoInclude();

        }

        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<Promotion> Promotions { get; set; } = null!;
        public DbSet<PromotionStatistic> PromotionStatistics { get; set; } = null!;
        public DbSet<Subscription> Subscriptions { get; set; } = null!;
    }
}
