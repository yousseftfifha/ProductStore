using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;

namespace PS.Data.Configurations
{
    public class InvoiceConfiguration: IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasOne(invoice => invoice.Product)
                .WithMany(product => product.Invoices)
                .HasForeignKey(invoice => invoice.ProductFK)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(invoice => invoice.MyClient)
                .WithMany(client => client.Invoices)
                .HasForeignKey(invoice => invoice.clientFk)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasKey(invoice => new {invoice.clientFk, invoice.ProductFK, invoice.dateAchat});
        }
    
        
    }
}