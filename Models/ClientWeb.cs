using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ClientWeb
    {
		[Key]
        public int Id { get; set; }

		[Display(Name = "Código Cliente")]
		public string CodClient { get; set; }

		[Display(Name = "Número Identificación")]
		public string? NumDocument { get; set; }

		[Display(Name = "Estado Cívil")]
		public string? CivilSta { get; set; }

		[Display(Name = "Fecha Nacimiento")]
		[DataType(DataType.Date)]
		public DateTime? Birthdat { get; set; }

		[Display(Name = "Nombre")]
		public string? SfirstName { get; set; }

		[Display(Name = "Apellido")]
		public string? SlastName { get; set; }

		[Display(Name = "Fecha Fallecimiento")]
		[DataType(DataType.Date)]
		public DateTime? DeathDat { get; set; }

		[Display(Name = "Fecha Ingreso")]
		[DataType(DataType.Date)]
		public DateTime InpDate { get; set; }

		[Display(Name = "Sexo")]
		public string Gender { get; set; }

		[Display(Name = "Tipo Persona")]
		public string Person_Type { get; set; }

		[Display(Name = "Nombre Legal")]
		public string? SlegalName { get; set; }

		[Display(Name = "Nombre Completo")]
		public string? SclieName { get; set; }

		[Display(Name = "Correo Electrónico")]
		public string? Email { get; set; }

		[Display(Name = "Número Telefónico")]
		public string? Phone_Number { get; set; }

        public int GetAge()
        {
			int age = 0;
			if (this.Birthdat != null)
            {
			    age = DateTime.Now.Year - this.Birthdat.Value.Year;

				DateTime birthNow = this.Birthdat.Value.AddYears(age);

				if (DateTime.Now.CompareTo(birthNow) > 0)
				{
					age--;
				}
			} else
            {
				age = 0;
            }

			return age;
        }
	}
}
