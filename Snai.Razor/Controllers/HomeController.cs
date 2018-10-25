using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Snai.Razor.Models;

namespace Snai.Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeIndexModel
            {
                Greet = "Hello",
                Name = "Razor",
                Center = "CenterModel"
            };

            ViewData["Layout_Body"] = "Is Layout page";
            ViewData["View_Body"] = "Is View page"; 

            return View(model);
        }
    }
}