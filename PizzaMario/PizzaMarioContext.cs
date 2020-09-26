using System.Data.Entity;
using PizzaMario.Models;

namespace PizzaMario
{
    public class PizzaMarioContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Township> Townships { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}