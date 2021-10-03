using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCarStore.API.ApiModels
{
    public class VehicleTypeDTO: CreateVehicleTypeDTO
    {
        public int Id { get; set; }
    }

    public class CreateVehicleTypeDTO
    {
        public string Type { get; set; }
    }
}
