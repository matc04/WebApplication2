using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Municipality
    {
         public int Id { get; set; }
         public int CodMunicipality { get; set; }
         public int CountryId { get; set; }
         public int ProvinceId { get; set; }
         public int LocalityId { get; set; }

        [Display(Name = "Muncipalidad")]
        public string  Name { get; set; }

        public Country Country { get; set; }

    }
}
