using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Route("[controller]")]
    public class ResimController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public ResimController(IWebHostEnvironment env)
        {
            _env = env;
        }
        /// <summary>
        /// Dosya Yükleme için gerekli olan metottur. https://www.findandsolve.com/articles/upload-file-using-ajax-in-asp-dot-net-core-dot-net-5 sitesinde anlatıyor.
        /// </summary>
        /// <returns></returns>
        [HttpPost("AddImageFile")]
        public IActionResult AddImageFile()
        {
            foreach (var item in Request.Form.Files)
            {
                string fullPath = Path.Combine(_env.ContentRootPath, "wwwroot\\files", item.FileName);
                using (FileStream fs = System.IO.File.Create(fullPath))
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

