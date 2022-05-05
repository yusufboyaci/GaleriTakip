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
    public class MusteriController : Controller
    {
        MusteriRepository db;
        public MusteriController(AppDbContext context)
        {
            db = new MusteriRepository(context);
        }
        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<Musteri> liste = db.GetActive();
            return Json(liste);
        }
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(Musteri nesne)
        {
            db.Add(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem Başarılı");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(Musteri nesne)
        {
            db.Update(nesne);
            db.Activate(nesne.Id);
            return Json("İşlem Başarılı");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(Musteri nesne)
        {
            db.Remove(nesne);
            return Json("İşlem başarılı");
        }
        [HttpGet("Login")]
        public IActionResult Login(string kullaniciAdi, string sifre)
        {
            bool result = db.KimlikKontrolEt(kullaniciAdi, sifre);
            if (result)
            {
                Musteri nesne = db.MusteriyiKullaniciAdiylaGetir(kullaniciAdi);
                return Json(nesne);
            }
            else
            {
                return Json("Böyle bir kullanıcı bulunmamaktadır");
            }
        }
    }
}
