using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(120)")]
        public string EnglishName { get; set; }

        public int AddressId { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Address Address { get; set; }
    }
}
