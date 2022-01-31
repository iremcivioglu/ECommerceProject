using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Pages.CustomerList
{
    public class IndexModel : PageModel
    {
        private readonly ECommerceDbText _context;

        public IndexModel(ECommerceDbText context)
        {
            _context = context;
        }

        public IEnumerable<Customer> Customers { get; set; }

        public async Task OnGet()
        {
            Customers = await _context.Customers.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
