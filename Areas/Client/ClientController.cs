using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models.Enums;
using System.Data.Entity;
using Microsoft.AspNetCore.Http;
using Areas.Client.Models;
using WebApplication2.Areas.Client.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication2.Library;
using System;

namespace WebApplication2.Areas.Client
{
    [Area("Client")]
    public class ClientController : Controller
    {
        private readonly WebApplication2DbContext _context;

        public string messageAction = " ";

        public ClientController(WebApplication2DbContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public IActionResult List()
        {

            ClientSearchModel client = new ClientSearchModel();

            ViewData.Add("GenderItems", EnumHelper.SelectListFor<GenderEnum>());
            ViewData.Add("TypePersonItems", EnumHelper.SelectListFor<TypePersonEnum>());

            ViewData["messageAction"] = HttpContext.Session.GetString("messageAction");

            List<ClientWeb> clients = _context.ClientWeb.Take(50).ToList();

            JoinClass jointest = new JoinClass
            {
                Clients = clients,
                ClientSearchModel = client
            };

            return View(jointest);

        }

        [HttpPost]
        public IActionResult PostList(ClientSearchModel model)
        {

            ViewData.Add("GenderItems", EnumHelper.SelectListFor<GenderEnum>());
            ViewData.Add("TypePersonItems", EnumHelper.SelectListFor<TypePersonEnum>());

            JoinClass jointest = new JoinClass();

            jointest.ClientSearchModel = model;

            IQueryable<ClientWeb> clients = _context.ClientWeb;

            if (ModelState.IsValid)
            { 

                if (model.SearchCodClient != null)
                {
                    clients = clients.Where(c => c.CodClient.Contains(model.SearchCodClient));
                }
                if (model.SearchEmail != null)
                {
                    clients = clients.Where(c => c.Email.Contains(model.SearchCodClient));
                }
                if (model.SearchSfirstName != null)
                {
                    clients = clients.Where(c => c.SfirstName.Contains(model.SearchSfirstName));
                }
                if (model.SearchSlastName != null)
                {
                    clients.Where(c => c.SlastName.Equals(model.SearchSlastName));
                }

                clients.Where(c => c.Gender.Equals(model.SearchGender));
                
                jointest.Clients = clients.ToList();

                return View("list", jointest);
            }
            else
            {

                jointest.Clients = clients.Take(50).ToList();

            }

            return View("list", jointest);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ClientWeb client = new ClientWeb();

            //var cliente = _context.ClientWeb.Where(x => x.Id == 1).ToList();

            //var cliente = _context.ClientWeb.Single(b => b.Id == 1);

            //var province = _context.Province.Find(2);

            // Load the blog related to a given post.
            //_context.Entry(province).Reference(p => p.Country).Load();

            //var country = _context.Country.Find(1);

            //_context.Entry(country).Collection(p => p.Provinces).Load();


            ViewData.Add("Gender", EnumHelper.SelectListFor<GenderEnum>());
            ViewData.Add("Person_Type", EnumHelper.SelectListFor<TypePersonEnum>());
            ViewData.Add("CivilSta", EnumHelper.SelectListFor<CivilStaEnum>());

            ViewData.Add("countrys", ListHelper.GetEntityIquery<Country>(_context.Country.ToList(), 0));
            ViewData.Add("provinces", new List<SelectListItem>());
            ViewData.Add("localities", new List<SelectListItem>());

            //Models.Address address = new Models.Address();

            return View(client);

        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(ClientWeb model)
        {
            int id = 0;

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);
                    await _context.SaveChangesAsync();

                    id = model.Id;

                    HttpContext.Session.SetString("messageAction", "La operación se realizó de manera exitosa");

                    if (HttpContext.Request.Form["modAction"].Equals("default"))
                    {
                        return Redirect("/client/client/list/");
                    }
                    else
                    {
                        string url = "/address/address/create?id=" + id;
                        return Redirect(url);
                    }
                }
                else
                {
                    HttpContext.Session.SetString("messageAction", "Ha ocurrido un error");
                    return Redirect("/client/client/list/");
                }
            }
            catch
            {
                HttpContext.Session.SetString("messageAction", "Ocurrio un error al intentar la operación");

                return Redirect("/client/client/list/");
            }

        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            ClientWeb client = _context.ClientWeb.Find(Id);

            _context.Entry(client).Collection(p => p.Addresses).Load();

            //client.Addresses.ForEach(element =>
            //{
            //    _context.Entry(element).Reference(p => p.Country).Load();
            //    _context.Entry(element).Reference(c => c.Province).Load();
            //    _context.Entry(element).Reference(c => c.Locality).Load();
            //    _context.Entry(element).Reference(c => c.Municipality).Load();
            //    _context.Entry(element).Reference(c => c.ZipCode).Load();
            //});

            ViewData.Add("Gender", EnumHelper.SelectListFor<GenderEnum>((GenderEnum)Enum.Parse(typeof(GenderEnum), client.Gender)));
            ViewData.Add("Person_Type", EnumHelper.SelectListFor<TypePersonEnum>((TypePersonEnum)Enum.Parse(typeof(TypePersonEnum), client.Person_Type)));
            ViewData.Add("CivilSta", EnumHelper.SelectListFor<CivilStaEnum>((CivilStaEnum)Enum.Parse(typeof(CivilStaEnum), client.CivilSta)));

            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> PostDetails(ClientWeb model)
        {

            try
            {
                if (ModelState.IsValid)
                {
               
                    _context.Update(model);
                    await _context.SaveChangesAsync();

                    HttpContext.Session.SetString("messageAction", "La operación se realizó de manera exitosa");

                }

                return Redirect("/client/client/list");
            }
            catch
            {
                return Redirect("details");
            }
        }

        [HttpGet]
        public IActionResult Create1()
        {
            ClientWebAddress client = new ClientWebAddress();

            ViewData.Add("Gender", EnumHelper.SelectListFor<GenderEnum>());
            ViewData.Add("Person_Type", EnumHelper.SelectListFor <TypePersonEnum>());
            ViewData.Add("CivilSta", EnumHelper.SelectListFor<CivilStaEnum>());

            List<SelectListItem> items = new List<SelectListItem>();

            ViewData.Add("provinces", new List<SelectListItem>());
            ViewData.Add("localities", new List<SelectListItem>());

            List<SelectListItem> countrys = ListHelper.GetEntityIquery<Country>(_context.Country.ToList(), 0);

            ViewData.Add("countrys", countrys);

            return View("create", client);
        }

        public IActionResult List1()
        {

            ClientWeb client = _context.ClientWeb.FirstOrDefault(c => c.Id == 1);

            _context.Entry(client).Collection(x => x.Addresses).Load();


            client.Addresses = _context.Address.Where(x => x.ClientWebId == 150).ToList();

            return View("ClientAddress", client);
        }
    }
}

