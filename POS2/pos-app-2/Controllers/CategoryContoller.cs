﻿using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;
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
            var entity = _service.Get();
            return View(entity);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save([Bind("CategoryName, Description")] CategoryModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new CategoryEntity(request));
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
        public IActionResult Update([Bind("Id, CategoryName, Description")] CategoryEntity request)
        {
            _service.Update(request);
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