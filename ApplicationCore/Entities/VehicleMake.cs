using MiniCarStore.ApplicationCore.Interfaces;

namespace MiniCarStore.ApplicationCore.Entities
{
    public class VehicleMake : BaseEntity, IAggregateRoot
    {
        public string Make { get; private set; }

        public VehicleMake(string make)
        {
            Make = make;
        }
    }
}
