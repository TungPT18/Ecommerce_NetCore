using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void DataSeeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
            new Language()
            {
                Id = new Guid(),
                Name = "Vietnamese",
                IsDefault = true,
                IsDeleted = false,
            }, 
            new Language() { 
                Id = new Guid(),
                Name = "English",
                IsDefault = false,
                IsDeleted = false,
            
            });
        }
    }
}
