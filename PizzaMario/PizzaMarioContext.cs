using System.Data.Entity;
using PizzaMario.Models;

namespace PizzaMario
{
    public class PizzaMarioContext : DbContext
    {
        public PizzaMarioContext()
            : base("name=PizzaMario")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Township> Townships { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<DeliveryRange> DeliveryRanges { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        public DbSet<AlternateOpeningHour> AlternateOpeningHours { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
    }
}