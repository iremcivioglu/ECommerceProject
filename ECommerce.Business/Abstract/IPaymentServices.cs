using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IPaymentServices
    {
        Task<Payment> CreatePayment(Payment payment);
        Task<Payment> GetPaymentById(int id);
        Task<IEnumerable<Payment>> GetPayments();
        Task DeletePayment(Payment payment);
        Task UpdatePayment(Payment paymentToUpdated, Payment payment);
        Task GetPaymentByType(string type);
    }
}
