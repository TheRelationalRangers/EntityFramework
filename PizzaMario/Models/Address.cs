﻿using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Addition { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public int SeriesIndicationStart { get; set; }
        public int SeriesIndicationEnd { get; set; }

        public Township Township { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}