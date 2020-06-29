using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.Price).IsRequired();

            builder.Property(n => n.OriginalPrice).IsRequired();

            builder.Property(n => n.SeoAlias).IsRequired().HasDefaultValue(0);

            builder.Property(n => n.ViewCount).IsRequired().HasDefaultValue(0);

            //builder.HasMany(n => n.OrderDetails).WithOne(m => m.Product);
        }
    }
}
