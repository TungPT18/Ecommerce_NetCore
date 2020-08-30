using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class ApplicationRolesConfiguration : IEntityTypeConfiguration<ApplicationRoles>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoles> builder)
        {
            builder.ToTable("ApplicationRoles");
        }
    }
}
