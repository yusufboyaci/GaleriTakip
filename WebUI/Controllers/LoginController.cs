using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebUI.ApiServices;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginApiService _loginService;
        public LoginController(LoginApiService loginApiService)
        {
            _loginService = loginApiService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel nesne)
        {
            if (await _loginService.GetirMusteri(nesne.KullaniciAdi, nesne.Sifre))
            {
                List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, nesne.KullaniciAdi)
            };

                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(userPrincipal);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }
    }
}
