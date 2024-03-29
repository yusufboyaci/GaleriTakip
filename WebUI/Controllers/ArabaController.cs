﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Authorize]
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ArabaUrl = "https://localhost:44372";
            ViewBag.GaleriUrl = "https://localhost:44303";
            ViewBag.DosyaUrl = "https://localhost:44314";
            ViewBag.WebUIUrl = "https://localhost:44302";
            return View();
        }
    }
}
