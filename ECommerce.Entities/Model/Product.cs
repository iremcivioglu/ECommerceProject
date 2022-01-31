using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities.Model
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductBrand { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public ICollection<Category> Categories  { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }

        //public List<SupplierProduct> SupplierProduct { get; set; }

    }
}
