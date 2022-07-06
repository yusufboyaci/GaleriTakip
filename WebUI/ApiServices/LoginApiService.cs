using Newtonsoft.Json;
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
        public async Task<bool> GetirMusteri(string kullaniciAdi, string sifre)
        {
            //var response = await _httpClient.GetAsync($"")
            LoginViewModel nesne = new LoginViewModel();
            nesne.KullaniciAdi = kullaniciAdi;
            nesne.Sifre = sifre;
            //HttpRequestMessage request = nesne
            //var response = await _httpClient.SendAsync()

            HttpResponseMessage response = await _httpClient.GetAsync($"Musteri/Login/{nesne}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return false;
            }

        }
    }
}
