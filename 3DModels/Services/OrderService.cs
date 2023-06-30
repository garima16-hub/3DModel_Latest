using _3DModels.Models;
using _3DModels.Repository;
using System.Collections.Generic;

namespace _3DModels.Services
{
    public class OrderService
    {
        private readonly OrderRepo _orderRepo;

        public OrderService(OrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepo.GetAllOrders();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepo.GetOrderById(id);
        }

        public string CreateOrder(Order order)
        {
            return _orderRepo.CreateOrder(order);
        }

        public string UpdateOrder(Order order)
        {
            return _orderRepo.UpdateOrder(order);
        }

        public string DeleteOrderById(int id)
        {
            return _orderRepo.DeleteOrderById(id);
        }
    }
}

