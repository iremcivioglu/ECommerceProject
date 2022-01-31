using ECommerce.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //Customer CreateCustomer(Customer customer);
        //Customer GetCustomerById(int id);
        //Task<List<Customer>> GetCustomers();
        //void DeleteCustomer(int id);
        //Customer UpdateCustomer(Customer customer);
    }
}
