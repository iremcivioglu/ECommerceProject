using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Model
{
    public class AppRole : IdentityRole<int>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
