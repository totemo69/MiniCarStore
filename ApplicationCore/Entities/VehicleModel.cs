using MiniCarStore.ApplicationCore.Interfaces;

namespace MiniCarStore.ApplicationCore.Entities
{
    public class VehicleModel : BaseEntity, IAggregateRoot
    {
        public string Model { get; private set; }

        public int MakeId { get; private set; }
        public VehicleMake Make { get; private set; }

        public VehicleModel(string model, int makeId)
        {
            Model = model;
            MakeId = makeId;
        }
    }
}
