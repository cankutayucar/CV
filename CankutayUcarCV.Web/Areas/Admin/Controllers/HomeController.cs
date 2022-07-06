using AutoMapper;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using CankutayUcarCV.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
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
        public HomeController(IKullaniciService kullaniciService, IMapper mapper, IToastNotification toastNotification)
        {
            var ses = new SessionOptions();

            _kullaniciService = kullaniciService;
            _mapper = mapper;
            _toastNotification = toastNotification;
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
            _toastNotification.AddSuccessToastMessage("işlem tamamdır");
            //if (ModelState.IsValid)
            //{
            //    var oldUser = await _kullaniciService.GetByIdAsync(model.id);
            //    var newUser = _mapper.Map(model, oldUser);
            //    if (model.Picture != null)
            //    {
            //        var oldImageName = oldUser.FOTOGRAF_URL;
            //        var imgname = Guid.NewGuid() +
            //                      Path.GetExtension(model.Picture.FileName);
            //        var path = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/img/", imgname);
            //        await using (var stream = new FileStream(path, FileMode.Create))
            //        {
            //             model.Picture.CopyTo(stream);
            //        }
            //        var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/img/", oldImageName);
            //        if (System.IO.File.Exists(oldImagePath))
            //        {
            //            System.IO.File.Delete(oldImagePath);
            //        }
            //        newUser.FOTOGRAF_URL = imgname;
            //        await _kullaniciService.UpdateAsync(newUser);
            //        _toastNotification.AddSuccessToastMessage("işlem tamamdır");
            //        return View(model);
            //    }
            //    return View(model);
            //}
            return View(model);
        }
    }
}
