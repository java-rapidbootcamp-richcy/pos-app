using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using pos_app_2.Models;
using System.Diagnostics;

namespace pos_app_2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        public CategoryController(ApplicationDbContext context)
        {
            _service = new CategoryService(context);
        }

        public IActionResult List()
        {
            var Data = _service.Get();
            return View(Data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save([Bind("CategoryName, Description")] CategoryEntity request)
        {
            _service.Add(request);
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var category = _service.View(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var category = _service.View(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CategoryName, Description")] CategoryEntity category)
        {
            _service.Update(category);
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Category/List");
        }
    }
}