using System.Text.Json;
using AutoMapper;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DTOs.Concrete.YeteneklerDtos;
using CankutayUcarCV.Entities.Conncrete;
using CankutayUcarCV.Web.Helper.SecurityPassword;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
namespace CankutayUcarCV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Yetenekler> _yeteneklerService;
        private readonly IMapper _mapper;
        public HomeController(IService<Yetenekler> yeteneklerService, IMapper mapper)
        {
            _yeteneklerService = yeteneklerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var yeteneklerliste = await _yeteneklerService.GetAllAsync();
            var result = _mapper.Map<List<YeteneklerListDto>>(yeteneklerliste.ToList());
            return View(result);
        }
    }
}
