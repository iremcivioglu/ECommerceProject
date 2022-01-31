using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess
{
    public interface IOrderRepository : IRepository<Order>
    {
        //Order CreateOrder(Order order);
        //Order GetOrderById(int id);
        //Task<List<Order>> GetOrders();
        //void DeleteOrder(int id);
        //Order UpdateOrder(Order order);
        Task<Order> GetOrderByNumber(int number);
    }
}
