using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        public ProductController(ApplicationDbContext context)
        {
            _service = new ProductService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var product = _service.Get();
            return View(product);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddModal()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public IActionResult Save(
            [Bind("ProductName, Supplier, Category, QuantityPerUnit, UnitPrice, UnitInStock, UnitOnOrder, ReorderLevel, Discontinued")] ProductModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new ProductEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var product = _service.View(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var product = _service.View(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, ProductName, Supplier, Category, QuantityPerUnit, UnitPrice, UnitInStock, UnitOnOrder, ReorderLevel, Discontinued")] ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _service.Update(product);
                return Redirect("Index");
            }
            return View("Edit", product);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Product");
        }
    }
}
