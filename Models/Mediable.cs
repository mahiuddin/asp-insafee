using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Mediable
    {
        public int Id { get; set; }
        public int MediaId { get; set; }

        public int MediableId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string MediableType { get; set; }

        public Media Media { get; set; }
    }
}
