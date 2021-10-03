using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCarStore.API.ApiModels
{

    public class VehicleMakerDTO : CreateVehicleMakerDTO
    {
        public int Id { get; set; }
    }

    public class CreateVehicleMakerDTO
    {
        public string Make { get; set; }
    }

}
