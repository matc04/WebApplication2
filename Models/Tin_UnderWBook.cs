using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
	public class Tin_UnderWBook
	{

#nullable enable
		public decimal? Nexchange { get; set; }
		public decimal? Npremcover { get; set; }
		public decimal? Nsurcharge { get; set; }
		public decimal? Ndiscount { get; set; }
		public decimal? Ncapitalimp { get; set; }
		public decimal? Niva { get; set; }
		public decimal? Npercepiva { get; set; }
		public decimal? Npercepiibb { get; set; }
		public decimal? Ntax { get; set; }
		public decimal? Nstamp { get; set; }
		public decimal? Nstampdisco { get; set; }
		public decimal? Npremium { get; set; }

		[Display(Name = "Intermediario")]
		public decimal? Nintermed { get; set; }
		public decimal? Ncomamou { get; set; }
		public decimal? Nothercomm { get; set; }
		public decimal? Ncoshare { get; set; }
		public decimal? Nqlives { get; set; }
		public decimal? Ntratypei { get; set; }
		public decimal? Ntype_amend { get; set; }
		public decimal? Nannuaprem { get; set; }
		public decimal? Nid { get; set; }
		public decimal? Nprovince { get; set; }
		public decimal? Nproduct { get; set; }
		public string? Scertype { get; set; }
		public string? Spolitype { get; set; }
		public decimal? Ncurrency { get; set; }
		public string? Sofficialpol { get; set; }

		[Display(Name = "Mes")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal? Nmonth { get; set; }

		[Display(Name = "Ramo")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal? Nbranch { get; set; }

		[DataType(DataType.Date)]
		public DateTime? Dcompdate { get; set; }

		[Display(Name = "Póliza")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal? Npolicy { get; set; }

		[Display(Name = "Certificado")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal? Ncertif { get; set; }

		[Display(Name = "Recibo")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal? Nreceipt { get; set; }

		public decimal? Nusercode { get; set; }

		[Display(Name = "Fecha Emisión")]
		[DataType(DataType.Date)]
		public DateTime? Dissuedat { get; set; }

		[Display(Name = "Fecha Efecto")]
		[DataType(DataType.Date)]
		public DateTime? Deffecdate { get; set; }

		[Display(Name = "Fecha Vencimiento")]
		[DataType(DataType.Date)]
		public DateTime? Dexpirdat { get; set; }

		[Display(Name = "Capital Asegurado")]
		public decimal? Ncapital { get; set; }

		public int? IntermediaId { get; set; }


#nullable disable

		[Display(Name = "Origen")]
		public string Sorigin { get; set; }

		[Display(Name = "Año")]
		[DisplayFormat(DataFormatString = "{0:F0}")]
		public decimal Nyear { get; set; }

		public string Sprovisional { get; set; }

		[Display(Name = "Tipo")]
		public string Stype { get; set; }
		public string Sbrancht { get; set; }

		[Display(Name = "Ramo")]
		public string Sbranch { get; set; }
	
		[Display(Name = "Nombre Cliente")]
		public string Scliename { get; set; }

		[Display(Name = "Provincia")]
		public string Sprovince { get; set; }
		public string Snopayroll { get; set; }

    	[Display(Name = "Moneda")]
		public string Scurrency { get; set; }


		public Intermedia Intermedia { get; set; }

	}
}
