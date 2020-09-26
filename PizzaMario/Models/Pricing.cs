using System;

namespace PizzaMario.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}