using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities.Model
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [StringLength(50)]
        [Required]
        public string CategoryName { get; set; }
        [StringLength(100)]
        [Required]
        public string CategoryDescription { get; set; }
        public Product Products { get; set; }
    }
}
