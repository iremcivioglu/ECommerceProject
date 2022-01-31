using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Api.Pages
{
    public class IndexModel : PageModel
    {
        private ECommerceDbText _context;

        public IndexModel(ECommerceDbText context)
        {
            _context = context;
        }
    }
}
