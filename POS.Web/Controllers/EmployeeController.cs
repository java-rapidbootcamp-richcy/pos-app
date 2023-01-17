using Microsoft.AspNetCore.Mvc;
using POS.Service;
using POS.Repository;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _service;
        public EmployeeController(ApplicationDbContext context)
        {
            _service = new EmployeeService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Data = _service.Get();
            return View(Data);
        }

        [HttpGet]
        public IActionResult AddModal()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public IActionResult Save([Bind("LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath")] EmployeeModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new EmployeeEntity(request));
                return Redirect("Index");
            }
            return View("_Add", request);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var employee = _service.View(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var employee = _service.View(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath")] EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                _service.Update(employee);
                return Redirect("Index");
            }
            return View("Edit", employee);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Employee");
        }
    }
}
