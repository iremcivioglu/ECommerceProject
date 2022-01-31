using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Api.Pages.CategoryList
{
    public class EditModel : PageModel
    {
        private readonly ECommerceDbText _context;
        public EditModel(ECommerceDbText context)
        {
            _context = context;
        }
        [BindProperty]
        public Category Categories { get; set; }
        public async Task OnGet(int id)
        {
            Categories = await _context.Categories.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Categories.FindAsync(Categories.CategoryId);
                result.CategoryName = Categories.CategoryName;
                result.CategoryDescription = Categories.CategoryDescription;
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
