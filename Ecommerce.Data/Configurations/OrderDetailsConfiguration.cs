using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class OrderDetailsConfiguration: IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.IsDeleted).HasDefaultValue(false);

            builder.HasOne(n => n.Order).WithMany(m => m.OrderDetails).HasForeignKey(m => m.OrderId);

            builder.HasOne(n => n.Product).WithMany(m => m.OrderDetails).HasForeignKey(m => m.ProductId);
        }
    }
}
