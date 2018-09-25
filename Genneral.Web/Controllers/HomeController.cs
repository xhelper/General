using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Genneral.Web.Models;
using Genneral.Entities;
namespace Genneral.Web.Controllers
{
    public class HomeController : Controller
    {

        private GenneralDbContext _genneralDbContext;
        public HomeController(GenneralDbContext genneralDbContext)
        {
            this._genneralDbContext = genneralDbContext;
        }

        /// <summary>
        /// nihao
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

           var ss=  _genneralDbContext.Categories.ToList();
            var tepm=ss.Count;
           return Content(tepm.ToString());

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

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
