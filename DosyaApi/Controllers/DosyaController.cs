using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DosyaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DosyaController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public DosyaController(IWebHostEnvironment env)
        {
            _env = env;
        }
        /// <summary>
        /// Dosya Yükleme için gerekli olan metottur.
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadFile")]
        public IActionResult UploadFile()
        {
            foreach (var item in Request.Form.Files)
            {
                string fullPath = Path.Combine(_env.ContentRootPath, "wwwroot\\files", item.FileName);
                using(FileStream fs = System.IO.File.Create(fullPath))
                {
                    item.CopyTo(fs);
                    fs.Flush();
                }
                return Json(item.FileName);
            }
            return Json("Lütfen tekrar deneyiniz.");
        }
    }
}
