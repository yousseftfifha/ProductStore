﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;

namespace PS.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("MyCategories")
                .HasKey(c => c.CategoryId); 
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
        }
    }
}