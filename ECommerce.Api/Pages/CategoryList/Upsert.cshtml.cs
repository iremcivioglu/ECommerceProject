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
    public class UpsertModel : PageModel
    {
        private readonly ECommerceDbText _context;
        public UpsertModel(ECommerceDbText context)
        {
            _context = context;
        }
        [BindProperty]
        public Category Categories { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            Categories = new Category();
            if (id == null)
            {
                //create
                return Page();
            }

            //update
            Categories = await _context.Categories.FindAsync(id);
            if (Categories == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Categories.CategoryId == 0)
                {
                    _context.Categories.Add(Categories);
                }
                else
                {
                    _context.Categories.Update(Categories);
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
