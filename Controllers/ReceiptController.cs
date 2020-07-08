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
    public class ReceiptController : Controller
    {

        private readonly WebApplication2DbContext _context;

        public ReceiptController(WebApplication2DbContext context)
        {
            _context = context;
        }
        // GET: ReceiptController
        public ActionResult Lista()
        {

            ViewData["tituloTable"] = "Recibos";

            List<Tin_DXP> receipts = _context.Tin_DXP.ToList();

            return View(receipts);
        }

        public ActionResult ListaByIntermed(int? sClient)
        {

            ViewData["tituloTable"] = "Recibos de un Cliente";

            List<Tin_DXP> Receipts =  _context.Tin_DXP
                                            .Where(T => T.Sclient.Equals(sClient))
                                            .ToList();
            return View("Lista", Receipts);

        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(int? sClient)
        {
            ViewData["tituloTable"] = "Recibos de un Cliente";

            List<Tin_DXP> receipts = null;

            if (sClient != null)
            {

                receipts = _context.Tin_DXP
                                       .Where(T => T.Sclient.Equals(sClient))
                                       .ToList();

            }

            return View("Lista", receipts);  

        }

        // GET: ReceiptController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReceiptController/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
