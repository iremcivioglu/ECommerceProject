//using ECommerce.Business.Abstract;
//using ECommerce.DataAccess.Abstract;
//using ECommerce.DataAccess.Concrete;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.Business.Concrete
//{
//    public class PaymentServices : IPaymentServices
//    {
//        private IPaymentRepository paymentRepository;
//        public PaymentServices()
//        {
//            paymentRepository = new PaymentRepository();
//        }
//        public Payment CreatePayment(Payment payment)
//        {
//            return paymentRepository.CreatePayment(payment);
//        }

//        public void DeletePayment(int id)
//        {
//            paymentRepository.DeletePayment(id);
//        }

//        public Payment GetPaymentById(int id)
//        {
//            return paymentRepository.GetPaymentById(id);
//        }

//        public Payment GetPaymentByType(string type)
//        {
//            return paymentRepository.GetPaymentByType(type);
//        }

//        public async Task<List<Payment>> GetPayments()
//        {
//            return await paymentRepository.GetPayments();
//        }

//        public Payment UpdatePayment(Payment payment)
//        {
//            return paymentRepository.UpdatePayment(payment);
//        }
//    }
//}
