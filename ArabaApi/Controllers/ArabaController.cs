using DataAccess.Context;
using DataAccess.Repositories.Concrete;
using Entities;
using Microsoft.AspNetCore.Hosting;
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
            List<Araba> liste = db.GetActive();
            return Json(liste);
        }
        [HttpGet("ArabaVeGaleriTablosuListele")]
        public IActionResult ArabaVeGaleriTablosuListele()
        {
            return Json(db.ArabaVeGaleriTablosuListele());
        }
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(Araba nesne)
        {
            db.Add(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı!");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(Araba nesne)
        {
            db.Update(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı!");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(Araba nesne)
        {
            db.Remove(nesne);
            return Json("İşlem başarılı!");
        }
    }
}
