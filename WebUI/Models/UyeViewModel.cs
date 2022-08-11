using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    /// <summary>
    /// Musteri lerin ilk başta üye olabilmesi için yapıldı müşteri bilgisi içerir.Müşteri Entity sine bağlıdır.
    /// </summary>
    public class UyeViewModel
    {
        [Display(Name ="Adınız")]
        public string Ad { get; set; }
        [Display(Name = "Soyadınız")]
        public string Soyad { get; set; }
        [Display(Name = "Kullanıcı Adınız")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }
    }
}
