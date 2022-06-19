using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
