using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }

        public DateTime ChangeDate { get; set; }

        public int CourierId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string TrackingId { get; set; }


        [Column(TypeName = "varchar(1000)")]
        public string Comments { get; set; }

        public Order Order { get; set; }

        public Courier Courier { get; set; }
    }
}
