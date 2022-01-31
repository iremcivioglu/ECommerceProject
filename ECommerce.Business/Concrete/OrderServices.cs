//using ECommerce.Business.Abstract;
//using ECommerce.DataAccess;
//using ECommerce.DataAccess.Concrete;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.Business.Concrete
//{
//    public class OrderServices : IOrderServices
//    {
//        private IOrderRepository orderRepository;
//        public OrderServices()
//        {
//            orderRepository = new OrderRepository();
//        }
//        public Order CreateOrder(Order order)
//        {
//            return orderRepository.CreateOrder(order);
//        }

//        public void DeleteOrder(int id)
//        {
//             orderRepository.DeleteOrder(id);
//        }

//        public Order GetOrderById(int id)
//        {
//            return orderRepository.GetOrderById(id);
//        }

//        public Order GetOrderByNumber(int number)
//        {
//            return orderRepository.GetOrderByNumber(number);
//        }

//        public async Task< List<Order>> GetOrders()
//        {
//            return await orderRepository.GetOrders();
//        }

//        public Order UpdateOrder(Order order)
//        {
//            return orderRepository.UpdateOrder(order);
//        }
//    }
//}
