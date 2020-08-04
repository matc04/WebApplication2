using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Intermedia
    {
        public int IntermediaId { get; set; }

        [Display(Name = "Codigo Intermediario")]
        public decimal Nintermed { get; set; }

#nullable enable

        public string? Sclient { get; set; }

        public decimal? Nintertyp { get; set; }

        public decimal? Nnullcode { get; set; }

        [DataType(DataType.Date)]

        public DateTime? Dnulldate { get; set; }

        public decimal? Noffice { get; set; }

        public decimal? Nsupervis { get; set; }

        public decimal? Nagency { get; set; }

        public decimal? NofficeAgen { get; set; }

#nullable disable


        [DataType(DataType.Date)]
        public DateTime Dcompdate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Dinpdate { get; set; }

        public decimal Nint_status { get; set; }


        
        
        public string Svalid { get; set; }

        public ICollection<Tin_UnderWBook> Tin_UnderWBooks { get; set; }


    }
}
