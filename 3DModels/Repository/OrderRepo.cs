using _3DModels.Models;
using System.Collections.Generic;
using System.Linq;


namespace _3DModels.Repository
{
    public class OrderRepo : IOrder
    {
        private readonly ModelDbContext _dbContext;

        public OrderRepo(ModelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return "Order created successfully.";
        }

        public string DeleteOrderById(int id)
        {
            var order = _dbContext.Orders.Find(id);
            if (order == null)
            {
                return "Order not found.";
            }

            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
            return "Order deleted successfully.";
        }

        public List<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _dbContext.Orders.Find(id);
        }



        public string UpdateOrder(Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
            return "Order updated successfully.";
        }


    }

}
