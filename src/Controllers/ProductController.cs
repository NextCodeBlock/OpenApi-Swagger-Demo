using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Services;

namespace SwaggerDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            return Ok(_productService.FindById(id));
        }

        [HttpPost("{name}")]
        public IActionResult Post(string name, decimal price, string category)
        {
            return Ok( _productService.AddProduct(name, price, category));
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            return Ok(_productService.Delete(id));
        }
    }
}
