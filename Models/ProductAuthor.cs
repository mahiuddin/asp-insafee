using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class ProductAuthor
    {
        public int ProductId { get; set; }
        public int AuthorId { get; set; }

        public Product Product { get; set; }
        public Author Author { get; set; }
    }
}
