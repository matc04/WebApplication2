using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PolicyController : Controller
    {

        private readonly WebApplication2DbContext _context;

        public PolicyController(WebApplication2DbContext context)
        {
            _context = context;
        }
        // GET: PolicyController
        public ActionResult Lista()
        {

            ViewData["tituloTable"] = "Pólizas";

            List<Tin_UnderWBook> policys = _context.Tin_UnderWBook.ToList();

            return View(policys);
        }

        public ActionResult ListaByIntermed(int? nIntermed)
        {

            ViewData["tituloTable"] = "Pólizas de un Intermediario";

            List<Tin_UnderWBook> policys =  _context.Tin_UnderWBook
                                            .Where(T => T.Nintermed == nIntermed)
                                            .ToList();
            return View("Lista", policys);

        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(int? nIntermed)
        {

            List<Tin_UnderWBook> policys = null;

            if (nIntermed != null)
            {


                ViewData["tituloTable"] = "Pólizas de un Intermediario";

                policys = _context.Tin_UnderWBook
                                       .Where(T => T.Nintermed == nIntermed)
                                       .ToList();

            }

            return View("Lista", policys);  

        }


        // GET: PolicyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PolicyController/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
