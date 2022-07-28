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
            ViewBag.ArabaUrl = "https://localhost:44373";
            return View();
        }
    }
}
