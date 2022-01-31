using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICustomerServices
    {
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> GetCustomerById(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task DeleteCustomer(Customer customer);
        Task UpdateCustomer(Customer customerToUpdated, Customer customer);
    }
}
