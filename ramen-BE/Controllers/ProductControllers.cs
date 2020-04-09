using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ramen_BE.Models;

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
            _context.ProductItems
        );
        
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> GetString()
        // {
        //     return new string[]{"this", "is", "noodles"};
        // }
    }
}