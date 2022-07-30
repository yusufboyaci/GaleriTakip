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
        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz!")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage ="Lütfen Şifre Giriniz!")]
        public string Sifre { get; set; }
    }
}
