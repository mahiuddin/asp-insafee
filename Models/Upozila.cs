using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Upozila
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(120)")]
        public string EnglishName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Url { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }

        public List<Address> addresses { get; set; }
    }
}