using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3DModels.Models;
using _3DModels.Services;

namespace _3DModels.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        



        public ProductController(ProductService productService)
        {
            _productService = productService;
            
        }

     


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }



        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }



        [HttpPost]
        public IActionResult AddProduct(Product products)
        {
            _productService.AddProduct(products);
            return CreatedAtAction(nameof(GetProductById), new { id = products.ModelId }, products);
        }



        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product products)
        {
            if (id != products.ModelId)
            {
                return BadRequest();
            }
            _productService.UpdateProduct(products);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}