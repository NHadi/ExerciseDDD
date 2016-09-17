using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class EmployeeService
    {
        private IEmployeeRepository employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public string GenerateCode()
        {
            return "E" + (employeeRepo.GetCount() + 1);
        }

        public Employee New()
        {
            return new Employee { Code = GenerateCode(), };
        }

        public Employee GetById(int id)
        {
            return employeeRepo.GetById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepo.GetAll();
        }

        public IEnumerable<Employee> Search(string search)
        {
            return employeeRepo.Search(search);
        }

        public void Dispose()
        {
            employeeRepo.Dispose();
        }
    }
}
