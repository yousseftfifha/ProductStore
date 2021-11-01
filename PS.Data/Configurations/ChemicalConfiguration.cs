using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;

namespace PS.Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(chemical => chemical.Address,
                address =>
                {
                    address.Property(address1 => address1.StreetAddress)
                        .HasMaxLength(50)
                        .HasColumnName("MyAddress");
                    address.Property(address1 => address1.City)
                        .IsRequired()
                        .HasColumnName("MyCity");
                });
         

        }
    }
}