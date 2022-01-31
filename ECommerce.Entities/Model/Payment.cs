using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [StringLength(50)]
        [Required]
        public string PaymentType { get; set; }
        [Required]
        public bool Allow { get; set; }
        public List<Order> Order { get; set; }
    }
}
