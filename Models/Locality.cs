using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Locality
    {
        [Key]
        public int Id { get; set; }

        public int CodLocality { get; set; }

        public int CountryId { get; set; }

        public int ProvinceId { get; set; }

        [Display(Name = "Localidad")]
        public string Name { get; set; }

        ////RELANTIONSHIP
        public Country Country { get; set; }
        public Province Province { get; set; }

    }
}
