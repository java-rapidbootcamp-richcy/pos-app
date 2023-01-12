using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;
using System.Reflection.Metadata.Ecma335;

namespace pos_app_2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _service;
        public CustomerController(ApplicationDbContext context)
        {
            _service = new CustomerService(context);
        }
        public IActionResult List()
        {
            var entity = _service.Get();
            return View(entity);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax")]CustomerModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new CustomerEntity(request));
                return Redirect("List");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var entity = _service.View(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _service.View(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax")] CustomerEntity request)
        {
            _service.Update(request);
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Customer/List");
        }
    }
}
