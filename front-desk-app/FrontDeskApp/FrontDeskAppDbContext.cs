using FrontDeskApp.Common.Models;
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
    }
}
