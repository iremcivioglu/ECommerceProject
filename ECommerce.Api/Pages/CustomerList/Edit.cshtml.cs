using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Api.Pages.CustomerList
{
    public class EditModel : PageModel
    {
        private readonly ECommerceDbText _context;
        public EditModel(ECommerceDbText context)
        {
            _context = context;
        }
        [BindProperty]
        public Customer Customers { get; set; }
        public async Task OnGet(int id)
        {
            Customers = await _context.Customers.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Customers.FindAsync(Customers.CustomerId);
                result.CustomerName = Customers.CustomerName;
                result.CustomerSurname = Customers.CustomerSurname;
                result.CustomerAdress = Customers.CustomerAdress;
                result.PhoneNumber = Customers.PhoneNumber;
                result.Email = Customers.Email;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
