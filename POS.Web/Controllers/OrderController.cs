using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _service;
        public OrderController(ApplicationDbContext context)
        {
            _service = new OrderService(context);
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
        public IActionResult Save([Bind("CustomerId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrderModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new OrderEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var order = _service.GetWithOrderDetails();
            return View(order);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var order = _service.ViewWithOrderDetails(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var order = _service.View(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CustomerId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrderModel order)
        {
            if (ModelState.IsValid)
            {
                _service.Update(order);
                return Redirect("Index");
            }
            return View("Edit", order);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Order");
        }
    }
}
