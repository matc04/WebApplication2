using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.Procedures
{
    public class GetTinUnderWBook
    {


		[Display(Name = "Origen")]
		public string Sorigin { get; set; }

		[Display(Name = "Año")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nyear { get; set; }

		[Display(Name = "Mes")]
		//[DisplayFormat(DataFormatString = "{0:F0}")]
		public string Nmonth { get; set; }
		
		public string Sprovisional { get; set; }

		[Display(Name = "Ramo")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nbranch { get; set; }

		[Display(Name = "Ramo")]
		public string Sbranch { get; set; }

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

		[Display(Name = "Nombre Cliente")]
		public string Scliename { get; set; }

		public decimal Npremium { get; set; }

		public int IntermediaId { get; set; }

		public decimal Total_Branch { get; set; }

		public decimal Total_Product { get; set; }


	}
}
