using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LamedhPos.UI.KonsoleWebApi.PosApp
{
    public class EmployeeController : ApiController
    {
        private EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService(new EmployeeEFRepo());
        }

        public Employee Get(int id)
        {
            return employeeService.GetById(id);
        }

        public IEnumerable<Employee> Get(string search)
        {
            return employeeService.Search(search);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                employeeService.Dispose();
            base.Dispose(disposing);
        }
    }
}
