using AutoMapper;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using CankutayUcarCV.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using CankutayUcarCV.Entities.Conncrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using NToastNotify;

namespace CankutayUcarCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(IKullaniciService kullaniciService, IMapper mapper, IToastNotification toastNotification, IWebHostEnvironment webHostEnvironment)
        {
            var ses = new SessionOptions();

            _kullaniciService = kullaniciService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            this._webHostEnvironment = webHostEnvironment;
        }

        [Authorize(Roles = "Administor")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _kullaniciService.FindByKullaniciAdiAsync(User.Identity.Name);

            var kullaniciListDto = _mapper.Map<KullaniciGuncelleViewModel>(user);


            return View(kullaniciListDto);
        }

        [Authorize(Roles = "Administor")]
        [HttpPost]
        public async Task<IActionResult> Index(KullaniciGuncelleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var oldUser = await _kullaniciService.GetByIdAsync(model.id);
                var newUser = _mapper.Map(model, oldUser);
                if (model.Picture != null)
                {
                    var oldImageName = oldUser.FOTOGRAF_URL;
                    var imgname = Guid.NewGuid().ToString() +
                                  Path.GetExtension(model.Picture.FileName);
                    var path = Path.Combine(_webHostEnvironment.WebRootPath, "img", imgname);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        model.Picture.CopyTo(stream);
                    }
                    var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", oldImageName);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                    newUser.FOTOGRAF_URL = imgname;
                }
                var result = await _kullaniciService.UpdateAsync(newUser);
                if (result)
                {
                    _toastNotification.AddSuccessToastMessage("Güncelleme İşlemi Başarılı");
                }
                else
                {
                    _toastNotification.AddErrorToastMessage("Güncelleme işlemi sırasında bir hata oluştu");
                }

                return View(_mapper.Map<KullaniciGuncelleViewModel>(newUser) ?? model);
            }
            var errorssss = "";
            foreach (var er in ModelState.Values)
            {
                foreach (var err in er.Errors)
                {
                    errorssss += err.ErrorMessage + Environment.NewLine;
                }
            }
            _toastNotification.AddWarningToastMessage(errorssss);
            return View(model);
        }

        [Authorize(Roles = "Administor")]
        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            return View(new KullaniciSifreDto());
        }

        [Authorize(Roles = "Administor")]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(KullaniciSifreDto model)
        {
            var result = await _kullaniciService.UpdatePasswordAsync(User.Identity.Name, model.EskiSifre,
                model.YeniSIFRE,
                model.YeniSIFREONAYLA);
            if (result)
            {
                _toastNotification.AddSuccessToastMessage("Şifre başarıyla değiştirilmiştir");
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Login", "Auth", new { area = "" });
            }
            else
            {
                _toastNotification.AddWarningToastMessage("işlem tamamlanamadı");
            }
            return View(model);
        }
    }
}
