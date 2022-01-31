//using ECommerce.DataAccess.Abstract;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class PaymentRepository : IRepository<Payment>, IPaymentRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public PaymentRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Payment Create(Payment variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deletePayment = GetById(id);
//            eCommerceDbText.Payments.Remove(deletePayment);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Payment>> GetAll()
//        {
//            return eCommerceDbText.Payments.ToList();
//        }

//        public Payment GetById(int id)
//        {
//            return eCommerceDbText.Payments.Find(id);
//        }
//        public Payment Update(Payment variable)
//        {
//            eCommerceDbText.Payments.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Payment GetPaymentByType(string type)
//        {
//            return eCommerceDbText.Payments.Where(w => w.PaymentType == type).FirstOrDefault();
//        }
//        //public Payment CreatePayment(Payment payment)
//        //{
//        //    eCommerceDbText.Add(payment);
//        //    eCommerceDbText.SaveChanges();
//        //    return payment;
//        //}

//        //public void DeletePayment(int id)
//        //{
//        //    var deletePayment = GetPaymentById(id);
//        //    eCommerceDbText.Payments.Remove(deletePayment);
//        //    eCommerceDbText.SaveChanges();

//        //}

//        //public Payment GetPaymentById(int id)
//        //{
//        //    return eCommerceDbText.Payments.Find(id);
//        //}

//        //public async Task<List<Payment>> GetPayments()
//        //{
//        //    return eCommerceDbText.Payments.ToList();
//        //}

//        //public Payment UpdatePayment(Payment payment)
//        //{
//        //    eCommerceDbText.Payments.Update(payment);
//        //    eCommerceDbText.SaveChanges();
//        //    return payment;
//    }
//}

