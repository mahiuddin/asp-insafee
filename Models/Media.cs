
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Media
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Title { get; set; }


        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }

        public int Type { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Source { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Mediable> mediables { get; set; }
    }
}
