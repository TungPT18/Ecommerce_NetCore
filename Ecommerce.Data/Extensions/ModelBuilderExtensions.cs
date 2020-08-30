using Ecommerce.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

            var roleId = new Guid();
            modelBuilder.Entity<ApplicationRoles>().HasData(new ApplicationRoles
            {
                Id = roleId,
                Name = "SystemAdministrator",
                NormalizedName = "systemadministrator",
                Description = "System Administrator"

            });
            var userId = new Guid();
            var hasher = new PasswordHasher<ApplicationUsers>();
            modelBuilder.Entity<ApplicationUsers>().HasData(new ApplicationUsers
            {
                Id = userId,
                UserName = "SystemAdmin",
                NormalizedUserName = "SystemAdmin",
                Email = "mynameisthanhtung@gmail.com",
                NormalizedEmail = "mynameisthanhtung@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = string.Empty,
                FirstName = "Thanh Tung",
                LastName = "Pham",
                DOB = new DateTime(2020, 17, 07)
            }); ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = userId
            });
        }
    }
}
