using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;

namespace PS.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                builder.HasMany(prod => prod.ListProviders)
                    .WithMany(prov => prov.ListProducts)
                    .UsingEntity(ass => ass.ToTable("associationProdProv"));
                builder.HasOne(prod => prod.MyCategory)
                    .WithMany(category => category.ListProducts)
                    .HasForeignKey(product => product.CategoryId)
                    .OnDelete(DeleteBehavior.NoAction);
          

            }
        }
}