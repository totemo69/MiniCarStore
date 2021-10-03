using Ardalis.GuardClauses;
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

        public void UpdateDetails(string make)
        {
            Guard.Against.NullOrEmpty(make, nameof(make));
            Make = make;
        }
    }
}
