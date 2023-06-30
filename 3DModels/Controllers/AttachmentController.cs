using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3DModels.Models;
using _3DModels.Services;

namespace _3DModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly AttachmentService _productService;
        

        public AttachmentController(AttachmentService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<List<Attachments>> GetProducts()
        {
            var products = _productService.GetAllAccessories();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Attachments> GetAccessoriesById(int id)
        {
            var attachment   = _productService.GetAccessoriesById(id);
            if (attachment == null)
            {
                return NotFound();
            }

            return Ok(attachment);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<string> CreateAccessories(Attachments attachment)
        {
            var result = _productService.CreateAccessories(attachment);
            return Ok(result);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<string> UpdateAccessories(int id, Attachments attachment)
        {
            if (id != attachment.product_id)
            {
                return BadRequest();
            }

            var result = _productService.UpdateAccessories(attachment);
            return Ok(result);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteAccessories(int id)
        {
            var result = _productService.DeleteAccessoriesById(id);
            return Ok(result);
        }
    }
}
