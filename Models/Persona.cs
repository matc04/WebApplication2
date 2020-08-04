using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Persona
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }

    }
}
