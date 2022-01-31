using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Supplier
    {
        //public Supplier()
        //{
        //    Customers = new Collection<Customer>();
        //}
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        [StringLength(50)]
        [Required]
        public string SupplierName { get; set; }
        public int CustomerId { get; set; }
        [StringLength(100)]
        [Required]
        public string Address { get; set; }
        [StringLength(11)]
        [Required]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Product> Products { get; set; }
        //public List<SupplierCustomer> SupplierCustomer { get; set; }

        //public List<SupplierProduct> SupplierProduct { get; set; }

    }
}
