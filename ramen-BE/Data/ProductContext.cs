using Microsoft.EntityFrameworkCore;
using ramen_BE.Models;
using ramen_BE.Data;

namespace ramen_BE.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) :base (options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
