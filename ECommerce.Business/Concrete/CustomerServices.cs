using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CustomerServices : ICustomerServices
    {
        private IUnitOfWork _unitOfWork;
        public CustomerServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _unitOfWork.Customers.AddAsync(customer);
            return customer;
        }

        public async Task DeleteCustomer(Customer customer)
        {
            _unitOfWork.Customers.Remove(customer);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _unitOfWork.Customers.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _unitOfWork.Customers.GetAllAsync();
        }

        public async Task UpdateCustomer(Customer customerToUpdated, Customer customer)
        {
            customerToUpdated.CustomerName = customer.CustomerName;
            await _unitOfWork.CommitAsync();
        }
    }
}
