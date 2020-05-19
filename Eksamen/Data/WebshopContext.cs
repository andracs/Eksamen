using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eksamen.Models;
using Microsoft.EntityFrameworkCore;

namespace Eksamen.Data
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ProductSeed 
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "HJC C70",
                    Price = 899,
                    Category = "Helmet",
                    Description = "En god hjelm til billige penge",
                    ProductImage = 1
                },
            new Product()
            {
                Id = 2,
                Name = "Bum",
                Price = 500,
                Category = "Helmet",
                Description = "En god hjelm til billige penge",
                ProductImage = 2
            });
            #endregion
        }
    }

}
