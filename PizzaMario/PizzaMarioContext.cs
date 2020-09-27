using System.Data.Entity;
using PizzaMario.EntityConfigurations;
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
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
        }
    }
}