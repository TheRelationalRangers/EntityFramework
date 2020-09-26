namespace PizzaMario.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Pricing Pricing { get; set; }
        public int Amount { get; set; }
    }
}