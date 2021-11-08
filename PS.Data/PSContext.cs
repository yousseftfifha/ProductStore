using System.Linq;
using System.Runtime.Intrinsics.X86;
using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;

namespace PS.Data
{
    public class PSContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
            Initial Catalog = ProductStoreDB; 
            Integrated Security = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            foreach (var prop in modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(type => type.GetProperties())
                .Where(p=>p.Name.StartsWith("Name")))
            {
                prop.SetColumnName("MyName");
            }
            /* 
            //TPH table per hierarchy
           modelBuilder.Entity<Product>()
                .HasDiscriminator<int>("IsBiological")
                .HasValue<Biological>(1)
                .HasValue<Chemical>(2)
                .HasValue<Product>(0);
            //TPT table per type
            modelBuilder.Entity<Biological>().ToTable("Biologicals");
            modelBuilder.Entity<Chemical>().ToTable("Chemicals");
            */
        }
    }
}