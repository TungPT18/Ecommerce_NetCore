using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.IsActive).HasDefaultValue(false);

            builder.Property(n => n.IsDeleted).HasDefaultValue(false);

            //builder.HasMany(n => n.OrderDetails).WithOne(m => m.Order);
        }
    }
}
