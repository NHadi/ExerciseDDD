using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamedhPos.UI.Web.AspNetMvc.PosApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeEFRepo employeeRepo;
        private EmployeeService service;

        public EmployeeController()
        {
            employeeRepo = new EmployeeEFRepo();
            service = new EmployeeService(employeeRepo);
        }

        public ActionResult Index()
        {
            var employees = employeeRepo.GetAll();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var employee = employeeRepo.GetById(id);
            return View(employee);
        }

        public ActionResult Create()
        {
            var employee = service.New();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employeeRepo.Save(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var employee = employeeRepo.GetById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            employeeRepo.Save(employee);
            return RedirectToAction("Index");
        }
    }
}