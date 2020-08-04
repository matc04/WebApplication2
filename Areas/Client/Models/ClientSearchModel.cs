using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Core;
using WebApplication2.Models.Enums;

namespace Areas.Client.Models
{
    /// <summary>
    /// Represents a client search model
    /// </summary>
    /// 
   
    public partial class ClientSearchModel : BaseSearchModel
    {
        #region Ctor

        public ClientSearchModel()
        {
            //SelectedClientRoleIds = new List<int>();
            //AvailableClientRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [Display(Name = "Codigo Cliente")]
        public string SearchCodClient { get; set; }

        [Display(Name = "Email")]
        public string SearchEmail { get; set; }

        [Display(Name = "Nombre")]
        public string SearchSfirstName { get; set; }

        [Display(Name = "Apellido")]
        public string SearchSlastName { get; set; }

        [Display(Name = "Tipo Persona")]
        public TypePersonEnum SearchPersonType { get; set; }

        [Display(Name = "Tipo Persona")]
        public string SearchLegalName { get; set; }

        [Display(Name = "Sexo")]
        public GenderEnum SearchGender { get; set; }

        #endregion
    }
}