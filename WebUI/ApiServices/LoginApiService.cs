using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ApiServices
{
    public class LoginApiService
    {
        private readonly HttpClient _httpClient;
        public LoginApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LoginApiService> GetirMusteri(string kullaniciAdi, string sifre)
        {
            LoginViewModel nesne = new LoginViewModel();
            nesne.KullaniciAdi = kullaniciAdi;
            nesne.Sifre = sifre;
            var response = await _httpClient.GetAsync($"Musteri/{nesne}");
        }
    }
}
