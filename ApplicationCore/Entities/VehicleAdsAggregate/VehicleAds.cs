using Ardalis.GuardClauses;
using MiniCarStore.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCarStore.ApplicationCore.Entities.VehicleAdsAggregate
{
    public class VehicleAds : BaseEntity, IAggregateRoot
    {
        private VehicleAds()
        {
            // required by EF
        }

        public VehicleAds(
            string title,
            string slug,
            VehicleSpecs vehicleSpecs,
            PriceType priceType,
            decimal price,
            string comment,
            ContactDetails contactDetails,
            bool isDealer,
            string dealerABN
        )
        {
            Guard.Against.Null(vehicleSpecs, nameof(vehicleSpecs));

            Title = title;
            Slug = slug;
            PriceType = priceType;
            Price = price;
            Comment = comment;
            VehicleSpecs = vehicleSpecs;
            ContactDetails = contactDetails;
            IsDealer = isDealer;
            DealerABN = dealerABN;
        }
        
        public string Title { get; private set; }
        public string Slug { get; private set; }
        public PriceType PriceType { get; private set; }
        public decimal Price { get; private set; }
        public string Comment { get; private set; }
        public VehicleSpecs VehicleSpecs { get; private set; }
        public ContactDetails ContactDetails { get; private set; }
        public bool IsDealer { get; private set; }
        public string DealerABN { get; private set; }
    }
}
