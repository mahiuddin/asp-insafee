using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    enum Statuses
    {
        Draft,
        Published
    }

    enum ProductType
    {
        Books,    // 0
        Food,           // 1
        Clothes, // 6
        Toys    
    }

    [Comment("Product table is the main table of this project")]
    public class Product
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(120)")]
        public string EnglishName { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string ShortDescription { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public float MrPrice { get; set; }
        public float DiscountPrice { get; set; }
        public int ProductType { get; set; }

        [Comment("The Status of the product")]
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public List<ProductAuthor> productAuthors { get; set; }
        public List<ProductCategory> productCategories { get; set; }

        public List<ProductPublication> productPublications { get; set; }

        public List<OrderProduct> orderProducts { get; set; }
        public List<CartProduct> cartProducts { get; set; }
    }
}