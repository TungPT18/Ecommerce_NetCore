using Ecommerce.Data.Configurations;
using Ecommerce.Data.Entities;
using Ecommerce.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.EF
{
    public class EcommerceDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, Guid>
    {
        public EcommerceDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TungPT18 Configure Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryMappingConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUsersConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationRolesConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("ApplicationUserClaim").HasKey(n => n.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("ApplicationUserRole").HasKey(n => new { n.UserId, n.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("ApplicationUserLogin").HasKey(n => n.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("ApplicationRoleClaim").HasKey(n => n.RoleId);
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("ApplicationUserToken").HasKey(n => n.UserId);

            // TungPT18 Create Data Seeding
            //modelBuilder.DataSeeding();

            //base.OnModelCreating(modelBuilder);
        }

        // TungPT18 Create Model Code First
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ProductCategoryMapping> ProductCategoryMappings {get;set;}
    }
}
