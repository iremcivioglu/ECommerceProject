using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Shipment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipmentId { get; set; }
        [StringLength(50)]
        [Required]
        public string CompanyName { get; set; }
        [StringLength(50)]
        [Required]
        public string PhoneNumber { get; set; }
        public List<Order> Order { get; set; }
    }
}
