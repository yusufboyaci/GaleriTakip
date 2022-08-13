using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Authorize]
    public class MusteriController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WebUIUrl = "https://localhost:44302";
            ViewBag.ArabaUrl = "https://localhost:44372";
            return View();
        }
        public IActionResult Index_V2()
        {
            ViewBag.WebUIUrl = "https://localhost:44302";
            ViewBag.ArabaUrl = "https://localhost:44372";
            return View();
        }
        public IActionResult Ekle() => View();
        public IActionResult Guncelle() => View();
    }
}
