using ECommerce.Business.Abstract;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerServices _customerServices;
        public CustomersController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return (IEnumerable<Customer>)_customerServices.GetCustomers();
        }
        [HttpGet("{id}", Name = "Get")]
        public async Task<Customer> Get(int id)
        {
            return await _customerServices.GetCustomerById(id);
        }
        [HttpPost]
        public void SaveOrUpdate([FromForm] Customer customer)
        {
            if (customer.CustomerId == 0) _customerServices.Save(customer);
            else _customerServices.UpdateCustomer(customer);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerServices.Delete(id);
        }

    }
}
