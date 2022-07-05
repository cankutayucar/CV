using AutoMapper;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CankutayUcarCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly IMapper _mapper;
        public HomeController(IKullaniciService kullaniciService, IMapper mapper)
        {
            _kullaniciService = kullaniciService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Administor")]
        public async Task<IActionResult> Index()
        {
            var user = await _kullaniciService.FindByKullaniciAdiAsync(User.Identity.Name);
            var kullaniciListDto = _mapper.Map<KullaniciListDto>(user);
            return View(kullaniciListDto);
        }
    }
}
