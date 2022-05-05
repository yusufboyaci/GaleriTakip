using DataAccess.Context;
using DataAccess.Repositories.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaleriApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriController : Controller
    {
        GaleriRepository db;
        public GaleriController(AppDbContext context)
        {
            db = new GaleriRepository(context);
        }
        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<Galeri> liste = db.GetActive();
            return Json(liste);
        }
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(Galeri nesne)
        {
            db.Add(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(Galeri nesne)
        {
            db.Update(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(Galeri nesne)
        {
            db.Remove(nesne);
            return Json("İşlem başarılı");
        }

    }
}
