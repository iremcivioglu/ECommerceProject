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
    public class CreateModel : PageModel
    {
        private readonly ECommerceDbText _context;
        public CreateModel(ECommerceDbText context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Categories { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _context.Categories.AddAsync(Categories);
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
