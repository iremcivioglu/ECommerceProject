using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        //Payment CreatePayment(Payment payment);
        //Payment GetPaymentById(int id);
        //Task<List<Payment>> GetPayments();
        //void DeletePayment(int id);
        //Payment UpdatePayment(Payment payment);
        Task<Payment> GetPaymentByType(string type);

    }
}
