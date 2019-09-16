using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult plus(int id)
        {
            int i = id + 10;
            ViewData["Plus"] = i;
            return View();
        }
        public IActionResult multiply(int id)
        {
            int i = id * 10;
            ViewData["multiply"] = i;
            return View();
        }
        [Route("Minus/{a}/{b}")]
        public IActionResult Minus(int a, int b)
        {
            int i = a - b;
            ViewData["Minus"] = i;
            return View();
        }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPost(IFormCollection values)
        {
            ViewData["Name"] = values["name"];
            ViewData["email"] = values["email"];
            ViewData["ShowAlert"] = true;
            return View("Index");
        }

        public IActionResult Contact2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPost2(Contact model)
        {
            ViewData["Name"] = model.Name;
            ViewData["email"] = model.Email;
            ViewData["ShowAlert"] = true;
            return View("Index");
        }
    }
}
