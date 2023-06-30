using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _3DModels.Models;
using _3DModels.Services;

namespace _3DModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Ok(orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // POST: api/Orders
        [HttpPost]
        public ActionResult<string> PostOrder(Order order)
        {
            var result = _orderService.CreateOrder(order);
            return Ok(result);
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public ActionResult<string> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            var result = _orderService.UpdateOrder(order);
            return Ok(result);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteOrder(int id)
        {
            var result = _orderService.DeleteOrderById(id);
            return Ok(result);
        }
    }
}

