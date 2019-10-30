using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop_efcore.Data;
using shop_efcore.Models;

namespace shop_efcore.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices]DataContext context)
        {
            var products = await context.Products.Include(i => i.Category).ToListAsync();
            return products;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> GetById([FromServices]DataContext context)
        {
            var products = await context.Products.Include(i => i.Category).ToListAsync();
            return products;
        }
    }
}