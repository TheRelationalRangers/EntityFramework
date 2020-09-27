using System.Data.Entity.ModelConfiguration;
using PizzaMario.Models;

namespace PizzaMario.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // Table Configuration

            // Primary Key Configuration
            HasKey(c => c.Id);

            // Property Configuration
            Property(c => c.Id)
                .IsRequired();

            Property(c => c.Name)
                .HasMaxLength(25)
                .IsRequired();

            Property(c => c.Addition)
                .HasMaxLength(10);

            Property(c => c.LastName)
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.PhoneNumber)
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Mail)
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Password)
                .HasMaxLength(25);

            // Relation Configuration
            HasRequired(c => c.Address)
                .WithMany(a => a.Customers)
                .HasForeignKey(c => c.AddressId);
        }
    }
}