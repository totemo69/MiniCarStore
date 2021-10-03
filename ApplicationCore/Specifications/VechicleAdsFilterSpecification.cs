using Ardalis.Specification;
using MiniCarStore.ApplicationCore.Entities.VehicleAdsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCarStore.ApplicationCore.Specifications
{
    public class VechicleAdsFilterSpecification : Specification<VehicleAds>
    {
        public VechicleAdsFilterSpecification(int? vehicleTypeId, int? makerId, int? modelId, string year)
        {   
            // Implement specification
            // Query.Where();
        }
    }
}
