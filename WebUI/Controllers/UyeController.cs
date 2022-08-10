using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UyeController : Controller
    {
        public IActionResult Uye()
        {
            return View();
        }
    }
}
