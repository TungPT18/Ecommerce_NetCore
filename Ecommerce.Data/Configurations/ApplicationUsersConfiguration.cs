using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class ApplicationUsersConfiguration : IEntityTypeConfiguration<ApplicationUsers>
    {
        public void Configure(EntityTypeBuilder<ApplicationUsers> builder)
        {
            builder.ToTable("ApplicationUsers");
            builder.Property(n => n.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(n => n.LastName).IsRequired().HasMaxLength(200);

            
        }
    }
}
