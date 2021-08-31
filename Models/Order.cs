using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int AspnetuserId { get; set; }


        public float SubTotal { get; set; }

        public float Discount { get; set; }

        public float Tax { get; set; }

        public float ShippingCost { get; set; }
        public float Total { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Comments { get; set; }


        public int ShippingId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PaymentStatus { get; set; }

        public int PaymentMethod { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Address Address { get; set; }
    }
}
