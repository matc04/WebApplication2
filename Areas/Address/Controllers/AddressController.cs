using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Library;
using WebApplication2.Models;

namespace WebApplication2.Areas.Address.Controllers
{
    [Area("Address")]
    public class AddressController : Controller
    {

        private readonly WebApplication2DbContext _context;

        public string messageAction = " ";

        public AddressController(WebApplication2DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {

            var client = _context.ClientWeb.Include(x => x.Addresses);

            List<Models.Address> addresses = _context.Address.Take(50).ToList();

            return View(addresses);

        }

        [HttpGet]
        public ActionResult Create(int Id)
        {
            ViewData["ClientWebId"] = Id;
            ViewData.Add("CountryId", ListHelper.GetEntityIquery<Country>(_context.Country.ToList(), 0));

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(Models.Address model)
        {
            model.ClientWebId = int.Parse(HttpContext.Request.Form["ClientWebId"]);

            try
            {
                if (ModelState.IsValid)
                {
                    model.ClientWebId = int.Parse(HttpContext.Request.Form["ClientWebId"]);

                    _context.Add(model);
                    await _context.SaveChangesAsync();

                    HttpContext.Session.SetString("messageAction", "La operación se realizó de manera exitosa");

                }
                else
                {
                    HttpContext.Session.SetString("messageAction", "Ha ocurrido un error");
                }

                return Redirect("/client/client/list/");

            }
            catch
            {
                HttpContext.Session.SetString("messageAction", "Ocurrio un error al intentar la operación");

                return Redirect("/client/client/list/");
            }
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Models.Address address = _context.Address.Find(Id);

            ViewData.Add("CountryId", ListHelper.GetEntityIquery<Country>(_context.Country.ToList(), address.CountryId));
            ViewData.Add("ProvinceId", ListHelper.GetEntityIquery<Province>(_context.Province.Where(x => x.CountryId == address.CountryId).ToList(), address.ProvinceId));
            ViewData.Add("LocalityId", ListHelper.GetEntityIquery<Locality>(_context.Locality.Where(x => x.CountryId == address.CountryId)
                                                                                             .Where(x => x.ProvinceId == address.ProvinceId).ToList(), address.LocalityId));
            ViewData.Add("MunicipalityId", ListHelper.GetEntityIquery<Municipality>(_context.Municipality.Where(x => x.CountryId == address.CountryId)
                                                                                                         .Where(x => x.ProvinceId == address.ProvinceId)
                                                                                                         .Where(x => x.LocalityId == address.LocalityId).ToList(), address.MunicipalityId));
            ViewData.Add("ZipCodeId", ListHelper.GetEntityIquery<ZipCode>(_context.ZipCode.Where(x => x.CountryId == address.CountryId)
                                                                                          .Where(x => x.ProvinceId == address.ProvinceId)
                                                                                          .Where(x => x.LocalityId == address.LocalityId)
                                                                                          .Where(x => x.MunicipalityId == address.MunicipalityId).ToList(), "CodZipCode", address.ZipCodeId));

            return View("EditAddress", address);
        }

        [HttpPost]
        public async Task<IActionResult> PostEdit(Models.Address model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    _context.Update(model);
                    await _context.SaveChangesAsync();

                    HttpContext.Session.SetString("messageAction", "La operación se realizó de manera exitosa");

                }

                return Redirect("/client/client/details/"+model.ClientWebId);
            }
            catch
            {
                return Redirect("edit");
            }
        }

        [HttpGet]
        public JsonResult GetProvinces(int countryId)
        {

            List<SelectListItem> options = new List<SelectListItem>();

            if (countryId > 0)
            {

                List<Province> provinces = _context.Province.Where(x => x.CountryId == countryId).ToList();

               provinces.ForEach(element => options.Add(new SelectListItem { Value = element.Id.ToString(), Text = element.Name }));

            }

            return Json(options);
        }

        [HttpGet]
        public JsonResult GetLocalities(int countryId, int provinceId)
        {

            List<SelectListItem> options = new List<SelectListItem>();

            List<Locality> localities = _context.Locality.Where(x => x.CountryId == countryId)
                                                         .Where(x => x.ProvinceId == provinceId).ToList();

            localities.ForEach(element => options.Add(new SelectListItem { Value = element.Id.ToString(), Text = element.Name }));
            
            return Json(options);
        }

        [HttpGet]
        public JsonResult GetMunicipalities(int countryId, int provinceId, int localityId)
        {

            List<SelectListItem> options = new List<SelectListItem>();

            List<Municipality> municipalities = _context.Municipality.Where(x => x.CountryId == countryId)
                                                                     .Where(x => x.ProvinceId == provinceId)
                                                                     .Where(x => x.LocalityId == localityId).ToList();

            municipalities.ForEach(element => options.Add(new SelectListItem { Value = element.Id.ToString(), Text = element.Name }));
            
            return Json(options);
        }

        [HttpGet]
        public JsonResult GetZipCodes(int countryId, int provinceId, int localityId, int municipalityId)
        {

            List<SelectListItem> options = new List<SelectListItem>();

            List<ZipCode> zipcodes = _context.ZipCode.Where(x => x.Country.Id == countryId)
                                                     .Where(x => x.ProvinceId == provinceId)
                                                     .Where(x => x.LocalityId == localityId)
                                                     .Where(x => x.MunicipalityId == municipalityId).ToList();

            zipcodes.ForEach(element => options.Add(new SelectListItem { Value = element.Id.ToString(), Text = element.CodZipCode }));
   
            return Json(options);
        }
    }
}
