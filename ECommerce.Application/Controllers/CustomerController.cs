using ECommerce.Application.Helpers;
using ECommerce.Business.Abstract;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;
        private readonly ECommerceDbText _context;
        public CustomerController(ICustomerServices customerServices)
        {
            this._customerServices = customerServices;
        }

        [HttpGet("[action]")]
        public async Task<Response<IEnumerable<Customer>>> GetAllData()
        {
            var company = await _customerServices.GetCustomers();
            return new Response<IEnumerable<Customer>>().Ok(company.Count(), company);
        }
        [HttpPost("GetCustomers")]
        public async Task<Response<IEnumerable<Customer>>> GetCustomers()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;
                //var companies = await _companyServices.GetAllCompanies();
                var customerData = (from tempcustomer in await _customerServices.GetCustomers() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    customerData = customerData.OrderBy(s => s.CustomerName == (sortColumn + " " + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.CustomerName.Contains(searchValue)
                                                || m.CustomerSurname.Contains(searchValue)
                                                || m.CustomerAdress.Contains(searchValue)
                                                || m.PhoneNumber.Contains(searchValue)
                                                 || m.Email.Contains(searchValue));                                             
                }
                recordsTotal = customerData.Count();
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                //return Ok(jsonData);
                return new Response<IEnumerable<Customer>>().Ok(customerData.Count(), customerData);
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        [HttpPost("[action]")]
        public async Task<Response<Customer>> Create(Customer customer)
        {

            try
            {
                if (customer.CustomerId == 0)
                    await _customerServices.CreateCustomer(customer);
                else await _customerServices.UpdateCustomer(customer);
                return new Response<Customer>().Ok(1, customer);
            }
            catch (Exception ex)
            {
                return new Response<Customer>().Error(1, customer, ex.ToString());
            }

            //await _context.Customers.AddAsync(customer);
            // await _context.SaveChangesAsync();
            // return true;

        }

        [HttpPost("[action]/{id}")]
        public async Task Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _customerServices.GetCustomerById(id);

                await _customerServices.DeleteCustomer(deleteData);
            }


        }

    }
}
