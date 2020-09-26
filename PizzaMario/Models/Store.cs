namespace PizzaMario.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreNumber { get; set; }
        public Address Address { get; set; }
        public string CountryCode { get; set; }

        public DeliveryRange DeliveryRange { get; set; }
    }
}