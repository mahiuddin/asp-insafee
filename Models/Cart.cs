using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        
        [Required]
        public int AspnetuserId { get; set; }

        public float SubTotal { get; set; }

        public float Discount { get; set; }

        public float Tax { get; set; }
        public float Total { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<CartProduct> cartProducts { get; set; }
    }
}
