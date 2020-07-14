using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.Procedures;

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

            List<Tin_UnderWBook> policys = _context.Tin_UnderWBook.Take(50)
                                                                  .ToList();

            //List<Tin_DXP> intermeds = _context.Tin_DXP.ToList();

            //Intermedia inter = _context.Intermedia.Find(105);
            
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
            ViewData["tituloTable"] = "Pólizas de un Intermediario";

            List<Tin_UnderWBook> policys = null;

            if (nIntermed != null)
            {


                policys = _context.Tin_UnderWBook
                                       .Where(T => T.Nintermed == nIntermed)
                                       .ToList();

            }

            return View("Lista", policys);  

        }

        [HttpGet]
        //public ActionResult PolicysJson()
        public ActionResult PolicysJson()
        {
            //DateTime fromDate = Convert.ToDateTime("2018-01-01");
            //DateTime toDate = Convert.ToDateTime("2018-04-20");

            //Dictionary<string, decimal> totalBydate; // = new Dictionary<string, decimal>();

            ////get number of days
            //int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            //List<GetTinUnderWBook> suscriptions = _context.GetTinUnderWBook.FromSqlRaw("dbo.getTinUnderWBook {0}, {1}", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd")).ToList();


            return View();
        }   



        [HttpGet]
        //public ActionResult PolicysJson()
        public JsonResult DataJson(string initDate, string endDate)
        {
            DateTime fromDate = Convert.ToDateTime(initDate);
            DateTime toDate = Convert.ToDateTime(endDate);

            //Se crea el arreglo de objetos pra devolver la informacion
            object[] arr = new object[3];

            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            List<GetTinUnderWBook> suscriptions = _context.GetTinUnderWBook.FromSqlRaw("dbo.getTinUnderWBook {0}, {1}", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd")).ToList();

            var listSuscriptionByDate = (from suscription in suscriptions
                                         group suscription by suscription.Dissuedat
                                         into listSales
                                         select new
                                         {
                                             date = listSales.Key,  
                                             amount = listSales.Sum(item => item.Npremium)
                                         }).AsEnumerable();

            ////group period by days
            if (totalDays <= 7)
            {
                var netSalesByPeriod = (from suscription in listSuscriptionByDate
                                        group suscription by suscription.date.ToString("dd-MMM-yyyy")
                                         into listSales
                                        select new
                                        {
                                            date = listSales.Key,
                                            amount = listSales.Sum(item => item.amount)
                                        }).ToList();

                var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
                                        group suscription by suscription.Sbranch
                                          into listSales
                                        select new
                                        {
                                            branch = listSales.Key,
                                            netSales = listSales.Sum(item => item.Npremium)
                                        }).ToList();
            }
            ////group period by weeks
            else if (totalDays <= 30)
            {
                var netSalesByPeriod = (from suscription in listSuscriptionByDate
                                        group suscription by
                                        System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                          suscription.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                        into listSales
                                        select new
                                        {
                                            period = "Semana " + listSales.Key.ToString(),
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();

                var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
                                        group suscription by suscription.Sbranch
                                           into listSales
                                        select new
                                        {
                                            branch = listSales.Key,
                                            netSales = listSales.Sum(item => item.Npremium)
                                        }).ToList();

                // return Json(netSalesByPeriod);
                arr[0] = netSalesByPeriod;
                arr[1] = netSalesByBranch;
                arr[2] = suscriptions;

                return Json(arr);

            }
            else if (totalDays <= 365)
            {
                var netSalesByPeriod = (from suscription in listSuscriptionByDate
                                        group suscription by suscription.date.ToString("MMM-yyyy")
                                        into listSales
                                        select new
                                        {
                                            period = listSales.Key,
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();

                var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
                                              group suscription by suscription.Sbranch
                                              into listSales
                                              select new
                                              {
                                                  branch = listSales.Key,
                                                  netSales = listSales.Sum(item => item.Npremium)
                                              }).ToList();

                arr[0] = netSalesByPeriod;
                arr[1] = netSalesByBranch;
                arr[2] = suscriptions;

                return Json(arr);

            }

            return Json(listSuscriptionByDate);
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
