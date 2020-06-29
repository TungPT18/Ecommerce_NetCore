using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.IsDeleted).HasDefaultValue(false);

            builder.HasOne(n => n.Product).WithMany(m => m.Carts).HasForeignKey(m => m.ProductId);

            builder.Property(n => n.Quality).HasDefaultValue(0);

        }
    }
}
