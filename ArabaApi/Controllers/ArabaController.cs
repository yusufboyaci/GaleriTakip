using DataAccess.Context;
using DataAccess.Repositories.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaController : Controller
    {
        ArabaRepository db;
        public ArabaController(AppDbContext context)
        {
            db = new ArabaRepository(context);
        }
        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<Araba> arabalar = db.GetActive();
            return Json(arabalar);
        }
    }
}
