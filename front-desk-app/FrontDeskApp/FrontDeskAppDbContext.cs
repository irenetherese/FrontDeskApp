using FrontDeskApp.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrontDeskApp
{
    public class FrontDeskAppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityStorageInfo> FacilityStorageInfo { get; set; }
        public DbSet<Record> Records { get; set; }
        public FrontDeskAppDbContext(DbContextOptions<FrontDeskAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<FacilityStorageInfo>()
            .Property(d => d.BoxType)
            .HasConversion(new EnumToStringConverter<BoxType>());

            modelBuilder
           .Entity<Record>()
           .Property(d => d.BoxType)
           .HasConversion(new EnumToStringConverter<BoxType>());

            modelBuilder
           .Entity<Record>()
           .Property(d => d.Status)
           .HasConversion(new EnumToStringConverter<Status>());
        }
    }
}
