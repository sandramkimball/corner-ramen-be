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

        [HttpGet("products/id")] 
        public ActionResult<Product> Get(int id) 
        { 
            var product = db.ProductItems.Find(id); 

            if (product == null) 
            { 
                return NotFound(); 
            } 

            return product; 
        } 

        public string Index()
        {
            return "Where are the noodles?";
        }

        [HttpPut("products")] 
        public ActionResult<Product> Putt(int id) 
        { 
            var product = db.ProductItems.Insert(id); 

            if (product == null) 
            { 
                return NotFound(); 
            } 

            return product; 
        } 
        
    }
}