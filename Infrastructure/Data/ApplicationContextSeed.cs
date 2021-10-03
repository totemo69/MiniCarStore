using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MiniCarStore.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCarStore.Infrastructure.Data
{
    public class ApplicationContextSeed
    {
        public static async Task SeedAsync(ApplicationContext applicationContext,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                if (!await applicationContext.VehicleTypes.AnyAsync())
                {
                    await applicationContext.VehicleTypes.AddRangeAsync(
                        VehicleTypeSeeds());

                    await applicationContext.SaveChangesAsync();
                }

                if (!await applicationContext.VehicleMake.AnyAsync())
                {
                    await applicationContext.VehicleMake.AddRangeAsync(
                        VehicleMakerSeeds());

                    await applicationContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<ApplicationContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(applicationContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }

        static IEnumerable<VehicleType> VehicleTypeSeeds()
        {
            return new List<VehicleType>()
            {
                new VehicleType("Car"),
                new VehicleType("Motor"),
                new VehicleType("Airplane"),
                new VehicleType("Boat")
            };
        }

        static IEnumerable<VehicleMake> VehicleMakerSeeds()
        {
            return new List<VehicleMake>()
            {
                new VehicleMake("Honda"),
                new VehicleMake("Yamaha"),
                new VehicleMake("Kawasaki")
            };
        }
    }
}
