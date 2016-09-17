using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.EFRepositories
{
    public class EmployeeEFRepo : EFRepositoryBase<Employee, LamedhPosContext>, IEmployeeRepository, IDisposable
    {
        public Employee GetByCode(string code)
        {
            return posContext.Employees.Single(e => e.Code == code);
        }

        public IEnumerable<Employee> Search(string key)
        {
            return posContext.Employees.Where(e => e.Code.Contains(key) || e.Name.Contains(key));
        }

        protected override DbSet<Employee> GetDbSet()
        {
            return posContext.Employees;
        }
    }   
}
