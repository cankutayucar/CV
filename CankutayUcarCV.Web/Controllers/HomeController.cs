using Microsoft.AspNetCore.Mvc;

namespace CankutayUcarCV.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
