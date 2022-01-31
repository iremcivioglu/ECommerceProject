using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IOrderServices
    {
        Task<Order> CreateOrder(Order order);
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> GetOrderByNumber(int number);
        Task DeleteOrder(Order order);
        Task UpdateOrder(Order orderToUpdated, Order order);
    }
}
