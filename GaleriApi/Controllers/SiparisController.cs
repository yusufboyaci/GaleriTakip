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
    public class SiparisController : Controller
    {
        SiparisRepository db;
        public SiparisController(AppDbContext context)
        {
            db = new SiparisRepository(context);
        }
        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<Siparis> liste = db.GetActive();
            return Json(liste);
        }
        [HttpGet("OnaylanmamisSiparisleriListele")]
        public IActionResult OnaylanmamisSiparisleriListele()
        {
            List<Siparis> liste = db.OnaylanmamisSiparisleriListele();
            return Json(liste);
        }
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(Siparis nesne)
        {
            db.Add(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(Siparis nesne)
        {
            db.Update(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem başarılı");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(Siparis nesne)
        {
            db.Remove(nesne);
            return Json("İşlem başarılı");
        }
    }
}
