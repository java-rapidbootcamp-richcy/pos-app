using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class ShipperController : Controller
    {
        private readonly ShipperService _service;

        public ShipperController(ApplicationDbContext context)
        {
            _service = new ShipperService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _service.Get();
            return View(categories);
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
        [ValidateAntiForgeryToken]
        public IActionResult Save([Bind("CompanyName, Phone")] ShipperModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new ShipperEntity(request));
                return Redirect("Index");
            }

            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var shipper = _service.View(id);
            return View(shipper);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var shipper = _service.View(id);
            return View(shipper);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([Bind("Id, CompanyName, Phone")] ShipperModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Update(request);
                return Redirect("Index");
            }
            return View("Edit", request);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Shipper");
        }
    }
}