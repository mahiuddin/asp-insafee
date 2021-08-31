using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(120)")]
        public string EnglishName { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ShortCode { get; set; }

        public int ParentId { get; set; }

        public int Left { get; set; }
        public int Right { get; set; }
        public int Depth { get; set; }

        
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public List<ProductCategory> productCategories { get; set; }
    }
}
