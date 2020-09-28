using System.Data.Entity.ModelConfiguration;
using PizzaMario.Models;

namespace PizzaMario.EntityConfigurations
{
    public class StoreConfiguration : EntityTypeConfiguration<Store>
    {
        public StoreConfiguration()
        {
            // Table Configuration

            // Primary Key Configuration
            HasKey(s => s.Id);

            // Property Configuration
            Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(s => s.StoreNumber)
                .IsRequired();

            Property(s => s.CountryCode)
                .IsRequired();

            // Relation Configuration
            HasRequired(s => s.Address);

            HasRequired(s => s.DeliveryRange)
                .WithMany(d => d.Stores)
                .HasForeignKey(s => s.DeliveryRangeId);

            HasMany(s => s.OpeningHours)
                .WithRequired(o => o.Store)
                .HasForeignKey(s => s.StoreId);

            HasMany(s => s.AlternateOpeningHours)
                .WithRequired(o => o.Store)
                .HasForeignKey(s => s.StoreId);
        }
    }
}