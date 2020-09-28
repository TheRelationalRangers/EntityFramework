using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class DeliveryRange
    {
        public int Id { get; set; }
        public string MaxRange { get; set; }
        public string MinRange { get; set; }

        public ICollection<Store> Stores { get; set; }
    }
}