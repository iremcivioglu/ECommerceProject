using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public int OrderNumber { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public int ShipmentId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        //public List<Product> Product { get; set; }
        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }
    }
}
