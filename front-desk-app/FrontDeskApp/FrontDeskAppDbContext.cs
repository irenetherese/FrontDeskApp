using FrontDeskApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontDeskApp
{
    public class FrontDeskAppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityStorageInfo> FacilityStorageInfo { get; set; }
        public DbSet<Record> Records { get; set; }

        public FrontDeskAppDbContext(DbContextOptions<FrontDeskAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.Entity<FrontDeskApp>(vehicle =>
            // {
            //     vehicle.Property(v => v.Id).ValueGeneratedOnAdd();
            //     vehicle.Property(v => v.Name).IsRequired(true);
            //     vehicle.Property(v => v.Type).HasConversion<string>();

            //     vehicle.HasData(new FrontDeskApp
            //     {
            //         Id = 1,
            //         Name = "Truck#1",
            //         Type = FrontDeskAppType.Truck
            //     });
            // });

            // builder.Entity<Models.FrontDeskApp>(frontDeskApp =>
            // {
            //     frontDeskApp.Property(f => f.Id).ValueGeneratedOnAdd();
            // });

            // builder.Entity<FrontDeskAppFrontDeskApp>(vehicleFrontDeskApp =>
            // {
            //     vehicleFrontDeskApp.HasKey(vf => new { vf.FrontDeskAppId, vf.FrontDeskAppId });
            //     vehicleFrontDeskApp.HasOne(vf => vf.FrontDeskApp).WithMany(v => v.FrontDeskAppFrontDeskApps).HasForeignKey(vf => vf.FrontDeskAppId);
            //     vehicleFrontDeskApp.HasOne(vf => vf.FrontDeskApp).WithMany(f => f.FrontDeskAppFrontDeskApps).HasForeignKey(vf => vf.FrontDeskAppId);
            // });

            // builder.Entity<FrontDeskAppLogItem>(log =>
            // {
            //     log.Property(l => l.Id).ValueGeneratedOnAdd();
            //     log.OwnsOne(l => l.Location);
            // });
        }
    }
}
