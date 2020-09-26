namespace PizzaMario.Models
{
    public class Crust
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Diameter { get; set; }
        public Pricing Pricing { get; set; }
    }
}