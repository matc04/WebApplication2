using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Address
    {

        [Key]
        public int Id { get; set; }

        [HiddenInput]
        public int ClientWebId { get; set; }

        [Display(Name = "Calle/Avenida")]
        public string Street { get; set; }

        [Display(Name = "Nro. Casa/Edificio")]
        public decimal Building { get; set; }

        [Display(Name = "Nro. Piso")]
        public decimal Deck { get; set; }

        [Display(Name = "Letra")]
        public string Letter { get; set; }

        [Display(Name = "Pais")]
        public int CountryId { get; set; }

        [Display(Name = "Provincia")]
        public int ProvinceId { get; set; }

        [Display(Name = "Localidad")]
        public int LocalityId { get; set; }

        [Display(Name = "Municipalidad")]
        public int MunicipalityId { get; set; }

        [Display(Name = "Codigo Postal")]
        public int ZipCodeId { get; set; }

        ////RELANTIONSHIP
        public virtual ClientWeb ClientWeb { get; set; }
        public Country Country { get; set; }
        public Province Province { get; set; }

        public Locality Locality { get; set; }

        public Municipality Municipality { get; set; }

        public ZipCode ZipCode { get; set; }


    }
}
