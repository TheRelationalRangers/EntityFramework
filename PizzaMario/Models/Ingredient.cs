namespace PizzaMario.Models
{
    public class Ingredient 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsVegy { get; set; }
        public Pricing Pricing { get; set; }
    }
}