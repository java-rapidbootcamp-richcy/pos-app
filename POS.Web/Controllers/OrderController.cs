using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _service;
        public OrderController(OrderService service)
        {
            _service = service;
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddModal()
        {
            return PartialView("_Add");
        }

        public IActionResult Save([Bind("CustomersId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrderModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new OrderEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        public IActionResult Index()
        {
            var product = _service.GetWithOrderDetails();
            return View();
        }

        public IActionResult Details(int? id)
        {
            var order = _service.ViewWithOrderDetails(id);
            return View(order);
        }

        public IActionResult Update([Bind("Id, CustomersId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrderModel order)
        {
            if (ModelState.IsValid)
            {
                _service.Update(order);
                return Redirect("Index");
            }
            return View("Edit", order);
        }

        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Order");
        }
    }
}
