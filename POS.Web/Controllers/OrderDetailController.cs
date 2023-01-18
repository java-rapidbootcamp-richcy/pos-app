using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly OrderDetailService _service;
        public OrderDetailController(ApplicationDbContext context)
        {
            _service = new OrderDetailService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var orderDetail = _service.Get();
            return View(orderDetail);
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
        public IActionResult Save([Bind("OrderId, ProductId, UnitPrice, Quantity, Discount")]OrderDetailModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new OrderDetailEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var orderDetail = _service.View(id);
            return View(orderDetail);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var orderDetail = _service.View(id);
            return View(orderDetail);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, OrderId, ProductId, UnitPrice, Quantity, Discount")]OrderDetailModel orderDetail)
        {
            if (ModelState.IsValid)
            {
                _service.Update(orderDetail);
                return Redirect("Index");
            }
            return View("Edit", orderDetail);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/OrderDetail");
        }
    }
}
