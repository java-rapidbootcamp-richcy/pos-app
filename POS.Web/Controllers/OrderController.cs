using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _service;

        private readonly CustomerService _customerService;
        private readonly EmployeeService _employeeService;
        private readonly ShipperService _shipperService;
        private readonly ProductService _productService;

        public OrderController(ApplicationDbContext context)
        {
            _service = new OrderService(context);
            _customerService = new CustomerService(context);
            _employeeService = new EmployeeService(context);
            _shipperService = new ShipperService(context);
            _productService = new ProductService(context);
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
            ViewBag.Customer = new SelectList(_customerService.Get(), "Id", "CompanyName");
            ViewBag.Employee = new SelectList(_employeeService.Get(), "Id", "LastName");
            ViewBag.Shipper = new SelectList(_shipperService.Get(), "Id", "CompanyName");
            ViewBag.Product = new SelectList(_productService.Get(), "Id", "ProductName");
            return View();
        }

        [HttpPost]
        public IActionResult Save(
            [Bind("CustomerId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipperId, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, OrderDetailModels")] OrderModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(request);
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            var order = _service.ViewDetail(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Customer = new SelectList(_customerService.Get(), "Id", "CompanyName");
            ViewBag.Employee = new SelectList(_employeeService.Get(), "Id", "LastName");
            ViewBag.Shipper = new SelectList(_shipperService.Get(), "Id", "CompanyName");
            ViewBag.Product = new SelectList(_productService.Get(), "Id", "ProductName");
            var order = _service.View(id);

            return View(order);

        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CustomerId, EmployeeId, OrderDate, RequiredDate, ShippedDate, ShipperId, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, OrderDetailModels")] OrderModel order)
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

        [HttpGet]
        public IActionResult DeleteOrderDetail(int? id)
        {
            _service.DeleteOrderDetail(id);
            return Redirect("/Order");
        }
    }
}