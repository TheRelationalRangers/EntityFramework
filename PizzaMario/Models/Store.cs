using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaMario.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreNumber { get; set; }
        public string CountryCode { get; set; }

        public Address Address { get; set; }

        public int AddressId { get; set; }

        public virtual DeliveryRange DeliveryRange { get; set; }
        public int DeliveryRangeId { get; set; }

        public ICollection<OpeningHour> OpeningHours { get; set; }

        public ICollection<AlternateOpeningHour> AlternateOpeningHours { get; set; }
    }
}