using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Users : IdentityUser<int> 
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int UserId { get; set; }
        [StringLength(50)]
        [Required]
        public string UserName { get; set; }
        [StringLength(8)]
        [Required]
        public string Password { get; set; }
        //[StringLength(50)]
        //[Required]
        //public string Email { get; set; }
        //[ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
    }
}
