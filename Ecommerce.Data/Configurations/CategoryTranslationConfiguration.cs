using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Configurations
{
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.IsDeleted).HasDefaultValue(false);

            builder.HasOne(n => n.Category).WithMany(m => m.CategoryTranslations).HasForeignKey(m => m.CategoryId);

            builder.HasOne(n => n.Language).WithMany(m => m.CategoryTranslations).HasForeignKey(m => m.LanguageId);

        }
    }
}
