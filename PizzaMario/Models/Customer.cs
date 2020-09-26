using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMario.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addition { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
    }
}