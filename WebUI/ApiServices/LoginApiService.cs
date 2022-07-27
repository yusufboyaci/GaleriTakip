using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
            LoginViewModel nesne = new LoginViewModel();
            nesne.KullaniciAdi = kullaniciAdi;
            nesne.Sifre = sifre;
            string myContent = JsonConvert.SerializeObject(nesne);
            HttpContent httpContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"Musteri/Login", httpContent);
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
