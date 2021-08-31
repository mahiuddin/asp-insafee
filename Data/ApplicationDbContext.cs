using InsafeeApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsafeeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Address> Addresses { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartProduct> CartProducts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Courier> Couriers { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Media> Medias { get; set; }

        public DbSet<Mediable> Mediables { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAuthor> ProductAuthors { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductPublication> ProductPublications { get; set; }
        public DbSet<Publication> Publications { get; set; }

        public DbSet<Upozila> Upozilas { get; set; }


       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
       //     modelBuilder.Entity<ProductAuthor>()
       //         .HasKey(pc => new { pc.ProductId, pc.AuthorId });
       //     modelBuilder.Entity<ProductCategory>()
       //         .HasKey(pc => new { pc.ProductId, pc.CategoryId });
       //     modelBuilder.Entity<ProductPublication>()
       //         .HasKey(pp => new { pp.ProductId, pp.PublicationId });
       // }

    }
}
