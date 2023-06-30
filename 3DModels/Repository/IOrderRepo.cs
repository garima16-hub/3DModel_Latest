using _3DModels.Models;
using System.Collections.Generic;


namespace _3DModels.Repository
{
    public interface IOrder
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        string CreateOrder(Order order);
        string UpdateOrder(Order order);
        string DeleteOrderById(int id);
    }
}

