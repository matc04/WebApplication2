using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Tin_DXP
    {


		[Display(Name = "Origen")]
		public string Sorigin { get; set; }

		[Display(Name = "Año")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nyear { get; set; }

		[Display(Name = "Trinestre")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Ntrimester { get; set; }
		
		public string Sprovisional { get; set; }

		public string Sbrancht { get; set; }

		[Display(Name = "Ramo")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nbranch { get; set; }

		public decimal Nusercode { get; set; }

		[DataType(DataType.Date)]
		public DateTime Dcompdate { get; set; }

		[Display(Name = "Póliza")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Npolicy { get; set; }

		[Display(Name = "Certificado")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Ncertif { get; set; }

		[Display(Name = "Recibo")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nreceipt { get; set; }

		[Display(Name = "Fecha Emisión")]
		[DataType(DataType.Date)]
		public DateTime Dissuedat { get; set; }

		[Display(Name = "Fecha Efecto")]
		[DataType(DataType.Date)]
		public DateTime Deffecdate { get; set; }

		[Display(Name = "Fecha Vencimiento")]
		[DataType(DataType.Date)]
		public DateTime Dexpirdat { get; set; }

		[Display(Name = "Código Cliente")]
		public string Sclient { get; set; }

		[Display(Name = "Nombre Cliente")]
		public string Scliename { get; set; }

		[Display(Name = "Moneda")]
		public string Scurrency { get; set; }
		public decimal Nexchange { get; set; }
		public decimal Npremiumexp { get; set; }
		public decimal Npremiumpend { get; set; }
		public decimal Npending { get; set; }
		public decimal Ncommission { get; set; }
		public string Sofficialpol { get; set; }

	}
}
