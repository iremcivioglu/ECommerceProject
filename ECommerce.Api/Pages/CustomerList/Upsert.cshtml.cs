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
    public class UpsertModel : PageModel
    {
        private readonly ECommerceDbText _context;
        public UpsertModel(ECommerceDbText context)
        {
            _context = context;
        }
        [BindProperty]
        public Customer Customers { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            Customers = new Customer();
            if (id == null)
            {
                //create
                return Page();
            }

            //update
            Customers = await _context.Customers.FindAsync(id);
            if (Customers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Customers.CustomerId == 0)
                {
                    _context.Customers.Add(Customers);
                }
                else
                {
                    _context.Customers.Update(Customers);
                }
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
