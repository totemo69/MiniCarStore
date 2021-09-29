
using MiniCarStore.ApplicationCore.Interfaces;

namespace MiniCarStore.ApplicationCore.Entities.VehicleAdsAggregate
{
    public class VehicleSpecs: BaseEntity, IAggregateRoot
    {
        public string Type { get; private set; }
        public string Year { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        private VehicleSpecs() { }
        public VehicleSpecs(string type, string year, string make, string model)
        {
            Type = type;
            Year = year;
            Make = make;
            Model = model;
        }
    }
}
