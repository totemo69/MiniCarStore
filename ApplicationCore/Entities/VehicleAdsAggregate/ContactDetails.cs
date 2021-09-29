using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCarStore.ApplicationCore.Entities.VehicleAdsAggregate
{
    public class ContactDetails
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        public ContactDetails(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
