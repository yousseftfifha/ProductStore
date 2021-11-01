﻿using System.Runtime.Intrinsics.X86;
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
        }
    }
}