using System.Security.Claims;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace CankutayUcarCV.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IKullaniciService _kullaniciService;

        public AuthController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new KullaniciLoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(KullaniciLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _kullaniciService.CheckUserAsync(model.Eposta, model.Sifre);
                if (result.Result)
                {

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Eposta),
                        new Claim(ClaimTypes.Role, "Administor"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.BeniHatirla
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);



                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
            }
            return View(model);
        }
    }
}
