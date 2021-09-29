using MiniCarStore.ApplicationCore.Interfaces;

namespace MiniCarStore.ApplicationCore.Entities
{
    public class VehicleType : BaseEntity, IAggregateRoot
    {
        public string Type { get; private set; }

        public VehicleType(string type)
        {
            Type = type;
        }
    }
}
