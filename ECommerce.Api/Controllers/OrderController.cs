//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ECommerce.DataAccess;
//using ECommerce.DataAccess.Concrete;
//using ECommerce.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ECommerce.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderController : ControllerBase
//    {
//        private IOrderRepository orderRepository;
//        public OrderController()
//        {
//            orderRepository = new OrderRepository();
//        }
//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(orderRepository.GetOrders());
//        }
//        [HttpPost]
//        public IActionResult Post([FromBody] Order order)
//        {
//            return Ok(orderRepository.CreateOrder(order));
//        }
//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            if (orderRepository.GetOrderById(id) != null)
//            {
//                orderRepository.DeleteOrder(id);
//                return Ok("Deleted Order");
//            }
//            return NotFound();
//        }
//        [HttpPut]
//        public IActionResult Put([FromBody] Order order)
//        {
//            if (orderRepository.GetOrderById(order.OrderId) != null)
//            {
//                orderRepository.UpdateOrder(order);
//                return Ok("Updated Order");
//            }
//            return NotFound();
//        }

//    }
//}
