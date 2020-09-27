using System.Data.Entity.ModelConfiguration;
using PizzaMario.Models;

namespace PizzaMario.EntityConfigurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            // Table Configuration

            // Primary Key Configuration
            HasKey(a => a.Id);

            // Property Configuration
            Property(a => a.Id)
                .IsRequired();

            Property(a => a.Street)
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.HouseNumber)
                .HasMaxLength(4)
                .IsRequired();

            Property(a => a.Addition)
                .HasMaxLength(10);

            Property(a => a.ZipCode)
                .HasMaxLength(6)
                .IsRequired();

            Property(a => a.City)
                .HasMaxLength(85)
                .IsRequired();

            // Relation Configuration
            HasRequired(a => a.Township)
                .WithMany(t => t.Addresses)
                .HasForeignKey(a => a.TownshipId);
        }
    }
}