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
        [HttpGet("Getir")]
        public IActionResult Getir(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Ekle")]
        public IActionResult Ekle(Araba nesne)
        {
            //nesne.Status = Core.Enum.Status.Active;//Repositories te yaz.
            db.Add(nesne);
            return Json("İşlem başarılı!");
        }
        [HttpPut("Guncelle")]
        public IActionResult Guncelle(Araba nesne)
        {
            db.Update(nesne);
            return Json("İşlem başarılı!");
        }
        [HttpDelete("Sil")]
        public IActionResult Sil(Guid id)
        {
            db.Remove(id);
            return Json("İşlem başarılı!");
        }
        [HttpDelete("ListeSil")]
        public IActionResult ListeSil(List<Guid> ids)
        {
            foreach (Guid id in ids)
            {
                db.Remove(id);
            }
            return Json("İşlem başarılı!");
        }
    }
}
