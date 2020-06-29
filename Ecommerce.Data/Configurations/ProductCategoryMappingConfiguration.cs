using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class ProductCategoryMappingConfiguration : IEntityTypeConfiguration<ProductCategoryMapping>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryMapping> builder)
        {
            builder.ToTable("ProductCategoryMapping");

            builder.HasKey(n => new { n.ProductId, n.CategoryId});

            builder.HasOne(n => n.Product).WithMany(m => m.ProductCategoryMappings).HasForeignKey(m => m.ProductId);

            builder.HasOne(n => n.Category).WithMany(m => m.ProductCategoryMappings).HasForeignKey(m => m.CategoryId);

        }
    }
}
