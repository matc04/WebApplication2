using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Código del País")] 
        public int CodCountry { get; set; }

        [Display(Name = "País")]
        public string Name { get; set; }

        //RELATIONSHIPS
        public ICollection<Address> Addresses { get; set; }

        //public  ICollection<Province> Provinces { get; set; }
        public   List<Province> Provinces { get; set; }


    }
}
