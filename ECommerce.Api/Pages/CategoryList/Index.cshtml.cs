using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Pages.CategoryList
{
    public class IndexModel : PageModel
    {
        private readonly ECommerceDbText _context;

        public IndexModel(ECommerceDbText context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories { get; set; }

        public async Task OnGet()
        {
            Categories = await _context.Categories.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _context.Categories.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
