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
    public class SiparisDetayController : Controller
    {
        SiparisDetayRepository db;
        public SiparisDetayController(AppDbContext context)
        {
            db = new SiparisDetayRepository(context);
        }
        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<SiparisDetay> liste = db.GetActive();
            return Json(liste);
        }
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(SiparisDetay nesne)
        {
            db.Add(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(SiparisDetay nesne)
        {
            db.Update(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(SiparisDetay nesne)
        {
            db.Remove(nesne);
            return Json("İşlem başarılı");
        }
    }
}
