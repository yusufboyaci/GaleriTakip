using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ArabaUrl = "https://localhost:44373";
            ViewBag.GaleriUrl = "https://localhost:44303";
            return View();
        }
    }
}
