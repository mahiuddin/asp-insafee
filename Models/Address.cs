using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsafeeApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AddressableType { get; set; }

        [Required]
        public int AddressableId { get; set; }


        [Column(TypeName = "varchar(300)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(120)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Fax { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string AddressLine2 { get; set; }

        public int ZipCode { get; set; }

        public int UpozilaId { get; set; }

        public int DistrictId { get; set; }

        public int CityId { get; set; }
        public int DivisionId { get; set; }

        public int CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Upozila Upozila { get; set; }
        public District District { get; set; }
        public Division Division { get; set; }
        public Country Country { get; set; }

        public List<Courier> couriers { get; set; }

        public List<Vendor> vendors { get; set; }


    }
}
