using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Api.Sevices;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace ECommerce.Api.Pages.CustomerList
{
    public class CustomersModel : PageModel
    {
        private readonly ICustomerRepository _customer;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRazorRenderService _renderService;
        private readonly ILogger<CustomersModel> _logger;

        public CustomersModel(ILogger<CustomersModel> logger, ICustomerRepository customer, IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _logger = logger;
            _customer = customer;
            _unitOfWork = unitOfWork;
            _renderService = renderService;
        }
        public IEnumerable<Customer> Customers { get; set; }
        public void OnGet()
        {
        }
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Customers = await _customer.GetAllAsync();
            return new PartialViewResult
            {
                ViewName = "_ViewAll",
                ViewData = new ViewDataDictionary<IEnumerable<Customer>>(ViewData, Customers)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", new Customer()) });
            else
            {
                var thisCustomer = await _customer.GetByIdAsync(id);
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", thisCustomer) });
            }
        }
        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    await _customer.AddAsync(customer);
                    await _unitOfWork.CommitAsync();
                }
                else
                {
                    customer.CustomerId = id;
                    await _customer.UpdateAsync(customer);
                    await _unitOfWork.CommitAsync();
                }
                Customers = await _customer.GetAllAsync();
                var html = await _renderService.ToStringAsync("_ViewAll", Customers);
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_CreateOrEdit", customer);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var customer = await _customer.GetByIdAsync(id);
            _customer.Remove(customer);
            await _unitOfWork.CommitAsync();
            Customers = await _customer.GetAllAsync();
            var html = await _renderService.ToStringAsync("_ViewAll", Customers);
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
