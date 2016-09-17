using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using LamedhPos.Infras.Data.SqlRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    class ProgramEF
    {
        static void Main(string[] args)
        {
            EmployeeEFRepo employeeRepo = new EmployeeEFRepo();
           // var employeeRepo = new EmployeeSqlRepository();
            var service = new EmployeeService(employeeRepo);
            var e = service.New();
            employeeRepo.Save( new Employee { Id = 2, Code = "E02", Name = "Nancy Davolio", Birthdate = DateTime.Now.AddYears(-30)});
        }
    }
}
