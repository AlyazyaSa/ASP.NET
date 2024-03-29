﻿using BLL.Interfaces;
using BLL.Reposatory;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcadeyCompany.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        //IDepartmentReposatory depo = new DepartmentRepository();
        public DepartmentController(IDepartmentRepository departmentrepo)
        {

            _departmentRepo = departmentrepo;
        }
        public IActionResult Index()
        {
            var deps = _departmentRepo.GetAll();
            return View(deps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _departmentRepo.Get(id.Value);
            return View(dep);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dep)
        {
            //if(dep == null)
            //{
            //    return BadRequest();
            //}
            if (ModelState.IsValid)
            {
                _departmentRepo.Create(dep);

                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _departmentRepo.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Department dep)
        {
            if (ModelState.IsValid)
            {
                _departmentRepo.Update(dep);
                return RedirectToAction("Index");
            }
            return View(dep);
        }

        public ActionResult Delete(int id)
        {
            var dep = _departmentRepo.Get(id);
            _departmentRepo.Delete(dep);
            return RedirectToAction("Index");
        }

    }
}