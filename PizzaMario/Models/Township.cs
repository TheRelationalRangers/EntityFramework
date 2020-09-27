using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Township
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}