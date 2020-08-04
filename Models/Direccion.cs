using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Direccion
    {

        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Letra { get; set; }

        public int? Contactoid { get; set; }
        public virtual Persona Persona { get; set; }

    }
}
