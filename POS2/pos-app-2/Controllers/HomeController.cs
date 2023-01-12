using Microsoft.AspNetCore.Mvc;

namespace pos_app_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
