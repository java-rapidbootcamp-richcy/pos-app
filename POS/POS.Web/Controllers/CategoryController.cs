using Microsoft.AspNetCore.Mvc;
using POS.DataContext;
using POS.Service;

namespace POS.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        public CategoryController(AppDbContext context)
        {
            _service = new CategoryService(context);
        }
        public IActionResult Index()
        {
            var data = _service.GetCategories();
            return View(data);
        }
    }
    
}