using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Customer
    {
        
        //public Customer()
        //{
        //    Suppliers = new Collection<Supplier>();
        //}
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerName { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerSurname { get; set; }
        [StringLength(11)]
        [Required]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        [Required]
        public string CustomerAdress { get; set; }
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        public ICollection<Order> Order { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }
        
        public ICollection<Supplier> Suppliers { get; set; }
        //public Supplier Supplier { get; set; }

    }
}
