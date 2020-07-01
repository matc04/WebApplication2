using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;
using WebApplication2.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private const string R1 = "Administrador";
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {

               return View();
        }

        ////[Authorize(Roles = R1)]
        //public IActionResult DashBoard()
        //{
        //    // get user's Name (email address) from Identity (dbo.AspNetUsers)
        //    string userName = "Manuel";

        //    List<IdentityUser> users = _context.Users.ToList();

        //    // get users last and first name (fname) from Identity with userName as a filter
        //    var pubNameQuery = from n in _context.Users.AsNoTracking()
        //                       where n.UserName == userName
        //                       select n.UserName + ", " + n.Email;

        //    //    string fname = await pubNameQuery.SingleAsync();

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
