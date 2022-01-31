using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ECommerce.Api.Helpers;
using ECommerce.Business;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.DataAccess;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ECommerceProject.Api.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerServices _customerServices;
        private readonly ECommerceDbText _context;
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;
        public CustomerController(ECommerceDbText context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, ICustomerServices customerServices)
        {
            this._context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
            _customerServices = customerServices;

        }
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new { data = _context.Customers.ToList() });
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.Customers.FirstOrDefault(x => x.CustomerId == id);
            if (result == null)
            {
                return new JsonResult(new { success = false, message = "Error While Deleting" });
            }
            _context.Customers.Remove(result);
            await _context.SaveChangesAsync();
            return new JsonResult(new { success = true, message = "Deleting Successfyl" });
        }
        //[HttpGet("[action]")]
        //public async Task<ActionResult> Create([FromBody] Customer customer)
        //{
        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();
        //    return Ok("_CustomerModalPartial");
        //}
        [HttpPost("[action]")]
        public async Task<bool>  Create([FromBody]Customer customer)
        {

            //try
            //{
            _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return true;
            //}
            //catch (Exception ex)
            //{
            //    return new Response<Customer>().Error(1, customer, ex.ToString());
            //}
        }
        //[HttpPost("[action]")]
        //public async Task<bool> Create([FromBody] Category category)
        //{
        //    _context.Categories.Add(category);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}
        /// <summary>
        /// Customer'ın tüm verilerini alır.
        /// </summary>
        /// <returns></returns>
        ///
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAll()
        {
            var customers = await _customerServices.GetCustomers();
            return Ok(customers);
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
                var customerData = (from tempcustomer in await _customerServices.GetCustomers() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    customerData = customerData.OrderBy(s=>s.CustomerName == (sortColumn + " " + sortColumnDirection));
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
        [HttpPost("LoadData")]
        public ActionResult LoadData()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();


                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data    
                var customerData = (from tempcustomer in _context.Customers
                                    select tempcustomer);

                //Sorting    
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                {
                    customerData = customerData.OrderBy(s => s.CustomerName == (sortColumn + " " + sortColumnDir));
                }
                //Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.CustomerName == searchValue);
                }

                //total number of rows count     
                recordsTotal = customerData.Count();
                //Paging     
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data    
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);

            }
            catch (Exception)
            {
                throw;
            }

        }
        //[HttpPost]
        //public IActionResult Delete([FromBody] Customer customer)
        //{
        //    this._context.Customers.Remove(customer);
        //    this._context.SaveChanges();
        //    return Ok(customer);
        //    //if (_context.Categories.Find(id) != null)
        //    //{
        //    //    var category = _context.Categories.Find(id);
        //    //    _context.Categories.Remove(category);
        //    //    _context.SaveChanges();
        //    //    return Ok("Deleted Customer");
        //    //}
        //    //return NotFound();
        //}
        [HttpGet]
        public ActionResult Edit(int? ID)
        {
            try
            {
                using (ECommerceDbText _context = new ECommerceDbText())
                {
                    var Customer = (from customer in _context.Customers
                                    where customer.CustomerId == ID
                                    select customer).FirstOrDefault();

                    return Ok(Customer);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult DeleteCustomers(int? ID)
        {
            using (ECommerceDbText _context = new ECommerceDbText())
            {
                var customer = _context.Customers.Find(ID);
                if (ID == null)
                {
                    var jsonData1 = new { data = "deleted" };
                    return Ok(jsonData1);
                }
                _context.Customers.Remove(customer);
                _context.SaveChanges();

                var jsonData = new { data = "deleted" };
                return Ok(jsonData);
            }
        }
        //[HttpPost("[action]/{id}")]
        //public async Task Delete(int id)
        //{
        //    if (id != 0)
        //    {
        //        var deleteData = await _customerServices.GetCustomerById(id);

        //        await _customerServices.DeleteCustomer(deleteData);
        //    }


        //}
        [HttpPost]
        public ActionResult DeleteCustomer(int id)
        {
            var deleteCustomer = _context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            if (deleteCustomer == null)
            {
                return new JsonResult(HttpStatusCode.BadRequest);
            }
            _context.Customers.Remove(deleteCustomer);
            _context.SaveChanges();
            return null;
        }
        /// <summary>
        /// AddAsync Method
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IActionResult Post([FromBody] Customer customer)
        //{
        //    var createCustomer = _customerServices.CreateCustomer(customer);
        //    return Ok(createCustomer);
        //}
        /// <summary>
        /// Delete Method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    if (_customerServices.GetCustomerById(id) != null)
        //    {
        //        _customerServices.DeleteCustomer(id);
        //        return Ok("Deleted Customer");
        //    }
        //    return NotFound();
        //}
        /// <summary>
        /// Update Method
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        //[HttpPut]
        //public IActionResult Put([FromBody] Customer customer)
        //{
        //    if (_customerServices.GetCustomerById(customer.CustomerId) != null)
        //    {
        //        return Ok(_customerServices.UpdateCustomer(customer));
        //    }
        //    return NotFound();
        //}
        //    [HttpGet("[action]")]
        //    public JsonResult GetById(int ID)  
        //{  
        //    var Employee = _context.ListAll().Find(x => x.CustomerId.Equals(ID));  
        //    return new JsonResult(Employee, System.Web.Mvc.JsonRequestBehavior.AllowGet);  
        //}  
    }
}
