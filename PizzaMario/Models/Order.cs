using System;

namespace PizzaMario.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Store Store { get; set; }
        public Customer Customer { get; set; }
        public Status Status { get; set; }
        public PaymentType PaymentType { get; set; }
        // Add Coupon

        public int StoreNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public string Comment { get; set; }
    }
}