using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ramen_BE.Models;
using ramen_BE.Data;

namespace ramen_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context) => _context = context;
        
       

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => (
            _context.Product
        );

        [HttpGet] 
        public Product FindProduct(int id) 
        { 
            var product = _context.Product.Find(id); 

            if (product == null) 
            { 
               throw new System.ArgumentException("Product not Found");;
            } 

            return product; 
        } 

        public string Index()
        {
            return "Where are my noodles?";
        }

        
    }
}