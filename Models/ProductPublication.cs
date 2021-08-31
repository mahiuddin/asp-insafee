using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class ProductPublication
    {
        public int ProductId { get; set; }
        public int PublicationId { get; set; }

        public Product Product { get; set; }
        public Publication Publication { get; set; }
    }
}