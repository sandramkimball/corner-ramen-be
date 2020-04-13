using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ramen_BE.Data;
using ramen_BE.Models;
using System;
using System.Linq;

namespace ramen_BE.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProductContext>>()))
            {
                // Look for any product.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        ProductType = "Ramen",
                        Name = "Buffalo Wings",
                        Description = "Buffalos don't have wings.",
                        Price = 0099
                    }
                );
                context.SaveChanges();
            }
        }
    }
}