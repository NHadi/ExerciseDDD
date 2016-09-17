using MangoSale.Application.Interface;
using MangoSale.Domain.Entities;
using System.Web.Mvc;

namespace MangoSale.MVCWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeAppService _employeeAppService;

        public EmployeeController(IEmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var data = _employeeAppService.All(@readonly: true);

            return View(data);
        }

        public ActionResult Details(int id)
        {
            var employee = _employeeAppService.Get(id);
            return View(employee);
        }


        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _employeeAppService.Create(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var employee = _employeeAppService.Get(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            _employeeAppService.Update(employee);
            return RedirectToAction("Index");
        }
    }
}