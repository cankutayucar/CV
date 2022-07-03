using Microsoft.AspNetCore.Mvc;

namespace CankutayUcarCV.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
