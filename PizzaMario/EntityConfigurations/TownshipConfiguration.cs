using System.Data.Entity.ModelConfiguration;
using PizzaMario.Models;

namespace PizzaMario.EntityConfigurations
{
    public class TownshipConfiguration : EntityTypeConfiguration<Township>
    {
        public TownshipConfiguration()
        {
            // Table Configuration

            // Primary Key Configuration
            HasKey(t => t.Id);

            // Relation Configuration
            Property(t => t.Code)
                .IsRequired();

            Property(t => t.Name)
                .IsRequired();
        }
    }
}