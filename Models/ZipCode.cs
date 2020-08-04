using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ZipCode
    {

        public int Id { get; set; }

        public int CountryId { get; set; }

        public int ProvinceId { get; set; }

        public int LocalityId { get; set; }

        public int MunicipalityId { get; set; }

        [Display(Name = "Código Postal")]
        public string CodZipCode { get; set; }

        public Country Country { get; set; }

        public Province Province { get; set; }

        public Locality Locality { get; set; }

        public Municipality Municipality { get; set; }







    }
}
