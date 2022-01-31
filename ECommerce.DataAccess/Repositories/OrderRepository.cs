//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class OrderRepository : IRepository<Order>, IOrderRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public OrderRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Order Create(Order variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deleteOrder = GetById(id);
//            eCommerceDbText.Orders.Remove(deleteOrder);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Order>> GetAll()
//        {
//            return eCommerceDbText.Orders.ToList();
//        }

//        public Order GetById(int id)
//        {
//            return eCommerceDbText.Orders.Find(id);
//        }
//        public Order Update(Order variable)
//        {
//            eCommerceDbText.Orders.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Order GetOrderByNumber(int number)
//        {
//            return eCommerceDbText.Orders.Where(w => w.OrderNumber == number).FirstOrDefault();
//        }
//        //public Order CreateOrder(Order order)
//        //{
//        //    eCommerceDbText.Add(order);
//        //    eCommerceDbText.SaveChanges();
//        //    return order;
//        //}

//        //public void DeleteOrder(int id)
//        //{
//        //    var deleteOrder = GetOrderById(id);
//        //    eCommerceDbText.Orders.Remove(deleteOrder);
//        //    eCommerceDbText.SaveChanges();
//        //}

//        //public Order GetOrderById(int id)
//        //{
//        //    return eCommerceDbText.Orders.Find(id);
//        //}

//        //public async Task<List<Order>> GetOrders()
//        //{
//        //    return eCommerceDbText.Orders.ToList();
//        //}

//        //public Order UpdateOrder(Order order)
//        //{
//        //    eCommerceDbText.Orders.Update(order);
//        //    eCommerceDbText.SaveChanges();
//        //    return order;
//        //}
//    }
//}
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class OrderRepository : IRepository<Order>, IOrderRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public OrderRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Order Create(Order variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deleteOrder = GetById(id);
//            eCommerceDbText.Orders.Remove(deleteOrder);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Order>> GetAll()
//        {
//            return eCommerceDbText.Orders.ToList();
//        }

//        public Order GetById(int id)
//        {
//            return eCommerceDbText.Orders.Find(id);
//        }
//        public Order Update(Order variable)
//        {
//            eCommerceDbText.Orders.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Order GetOrderByNumber(int number)
//        {
//            return eCommerceDbText.Orders.Where(w => w.OrderNumber == number).FirstOrDefault();
//        }
//        //public Order CreateOrder(Order order)
//        //{
//        //    eCommerceDbText.Add(order);
//        //    eCommerceDbText.SaveChanges();
//        //    return order;
//        //}

//        //public void DeleteOrder(int id)
//        //{
//        //    var deleteOrder = GetOrderById(id);
//        //    eCommerceDbText.Orders.Remove(deleteOrder);
//        //    eCommerceDbText.SaveChanges();
//        //}

//        //public Order GetOrderById(int id)
//        //{
//        //    return eCommerceDbText.Orders.Find(id);
//        //}

//        //public async Task<List<Order>> GetOrders()
//        //{
//        //    return eCommerceDbText.Orders.ToList();
//        //}

//        //public Order UpdateOrder(Order order)
//        //{
//        //    eCommerceDbText.Orders.Update(order);
//        //    eCommerceDbText.SaveChanges();
//        //    return order;
//        //}
//    }
//}
