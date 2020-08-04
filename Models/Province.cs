using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        public int CountryId { get; set; }

        public int CodProvince { get; set; }

        [Display(Name = "Provincia")]
        public string Name { get; set; }

        //////RELANTIONSHIP
        public Country Country { get; set; }

        //public ICollection<Locality> Localities { get; set; }

    }
}
