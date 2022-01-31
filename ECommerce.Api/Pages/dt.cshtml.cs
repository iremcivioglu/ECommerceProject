using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Pages
{
    public class dtModel : PageModel
    {
        ECommerceDbText _context;

        public dtModel(ECommerceDbText context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
    //    public IList<Category> Category { get; set; }

    //    public async Task OnGetAsync()
    //    {
    //        Category = await _context.Categories.ToListAsync();
    //    }
    //    public async Task<IActionResult> OnPostAsync()
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return Page();
    //        }

    //        _context.Categories.Add((Category)Category);
    //        await _context.SaveChangesAsync();

    //        return RedirectToPage("./dt");
    //    }
    //}
    //public IActionResult OnGetDisplay()
    //{
    //    var categories = _context.Categories.ToList();
    //    return new JsonResult(categories);
    }
}

