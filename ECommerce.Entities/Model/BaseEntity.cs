using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Model
{
    public class BaseEntity //Ortak olan alanları tekrar tekrar yazmamak için bu base classları kullanırız.
    {
        public DateTime CreatingTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsActived { get; set; }
    }
}
