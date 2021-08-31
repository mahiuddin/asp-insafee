using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Division
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(120)")]
        public string EnglishName { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Lat { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Lon { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Url { get; set; }

        public int CountryId { get; set; }
        
        public Country Country { get; set; }

        public List<Address> addresses { get; set; }

    }
}
