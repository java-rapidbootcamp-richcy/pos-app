using Microsoft.AspNetCore.Mvc;

namespace POS.Web.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
