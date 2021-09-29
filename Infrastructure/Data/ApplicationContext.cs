using Microsoft.EntityFrameworkCore;
using MiniCarStore.ApplicationCore.Entities;
using MiniCarStore.ApplicationCore.Entities.VehicleAdsAggregate;

namespace MiniCarStore.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }

        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleMake> VehicleMake { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        public DbSet<VehicleAds> VehicleAds { get; set; }
    }
}
