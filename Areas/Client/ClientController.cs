using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.Emit;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Areas.Client
{
    public class ClientController : Controller
    {
        private readonly WebApplication2DbContext _context;

        public ClientController(WebApplication2DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<ClientWeb> clients = _context.ClientWeb.ToList();

            int edad = clients[0].GetAge();

            int countAdult = clients.Where(x => x.GetAge() >= 18).Count();

            ViewData["countAdult"] =  countAdult;

            ViewData["countMinority"] =  clients.Count() - countAdult;

            int countMinority = clients.Count() - countAdult;

            var listPersonType = (from ClientWeb client in clients
                                        group client by client.Person_Type
                                          into listType
                                        select new
                                        {
                                            type = listType.Key,
                                            countType = listType.Count()
                                        }).ToList();

            foreach (var item in listPersonType)
            {
                ViewData[item.type] =  item.countType;
            }

            var listClientGender = (from ClientWeb client in clients
                                  group client by client.Gender
                                          into listGender
                                  select new
                                  {
                                      gender = listGender.Key,
                                      countGender = listGender.Count()
                                  }).ToList();

            foreach (var item in listClientGender)
            {
                ViewData[item.gender] =  item.countGender;
            }

            return View("DashBoard");
        }


        [HttpGet]
        //public ActionResult DataJson()
        public JsonResult DataJson(string initDate, string endDate)
        {
            DateTime fromDate = Convert.ToDateTime(initDate);
            DateTime toDate = Convert.ToDateTime(endDate);

            //Se crea el arreglo de objetos pra devolver la informacion
            object[] arr = new object[3];

            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            //List<GetTinUnderWBook> suscriptions = _context.GetTinUnderWBook.FromSqlRaw("dbo.getTinUnderWBook {0}, {1}", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd")).ToList();

            //var listSuscriptionByDate = (from suscription in suscriptions
            //                             group suscription by suscription.Dissuedat
            //                             into listSales
            //                             select new
            //                             {
            //                                 date = listSales.Key,
            //                                 amount = listSales.Sum(item => item.Npremium)
            //                             }).AsEnumerable();

            //////group period by days
            //if (totalDays <= 7)
            //{
            //    var netSalesByPeriod = (from suscription in listSuscriptionByDate
            //                            group suscription by suscription.date.ToString("dd-MMM-yyyy")
            //                             into listSales
            //                            select new
            //                            {
            //                                date = listSales.Key,
            //                                amount = listSales.Sum(item => item.amount)
            //                            }).ToList();

            //    var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
            //                            group suscription by suscription.Sbranch
            //                              into listSales
            //                            select new
            //                            {
            //                                branch = listSales.Key,
            //                                netSales = listSales.Sum(item => item.Npremium)
            //                            }).ToList();
            //}
            //////group period by weeks
            //else if (totalDays <= 30)
            //{
            //    var netSalesByPeriod = (from suscription in listSuscriptionByDate
            //                            group suscription by
            //                            System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            //                              suscription.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
            //                            into listSales
            //                            select new
            //                            {
            //                                period = "Semana " + listSales.Key.ToString(),
            //                                netSales = listSales.Sum(item => item.amount)
            //                            }).ToList();

            //    var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
            //                            group suscription by suscription.Sbranch
            //                               into listSales
            //                            select new
            //                            {
            //                                branch = listSales.Key,
            //                                netSales = listSales.Sum(item => item.Npremium)
            //                            }).ToList();

            //    // return Json(netSalesByPeriod);
            //    arr[0] = netSalesByPeriod;
            //    arr[1] = netSalesByBranch;
            //    arr[2] = suscriptions;

            //    return Json(arr);

            //}
            //else if (totalDays <= 365)
            //{
            //    var netSalesByPeriod = (from suscription in listSuscriptionByDate
            //                            group suscription by suscription.date.ToString("MMM-yyyy")
            //                            into listSales
            //                            select new
            //                            {
            //                                period = listSales.Key,
            //                                netSales = listSales.Sum(item => item.amount)
            //                            }).ToList();

            //    var netSalesByBranch = (from GetTinUnderWBook suscription in suscriptions
            //                            group suscription by suscription.Sbranch
            //                                  into listSales
            //                            select new
            //                            {
            //                                branch = listSales.Key,
            //                                netSales = listSales.Sum(item => item.Npremium)
            //                            }).ToList();

            //    arr[0] = netSalesByPeriod;
            //    arr[1] = netSalesByBranch;
            //    arr[2] = suscriptions;

            //    return Json(arr);

            //}

            return Json(arr);
        }



    }
}
