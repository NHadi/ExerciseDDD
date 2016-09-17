using MangoSale.Data.Repositories.Dapper.Common;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Repository.ReadOnly;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using DapperExtensions;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MangoSale.Data.Repositories.Dapper
{
    public class EmployeeDapperRepository : Repository, IEmployeeReadOnlyRepository
    {
        public Employee Get(int _id)
        {
            using (var cn = MangoSaleConnection)
            {
                var Employee = cn.Query<Employee>("SELECT * FROM Employee WHERE Id = @id",
                    new { id = _id }).FirstOrDefault();
                return Employee;
            }
        }

        public IEnumerable<Employee> All()
        {
            using (var cn = MangoSaleConnection)
            {
                var employee = cn.Query<Employee>("SELECT * FROM Employee");
                return employee;
            }
        }

        public IEnumerable<Employee> Find(Expression<Func<Employee, bool>> predicate)
        {
            using (var cn = MangoSaleConnection)
            {
                var Employee = cn.GetList<Employee>(predicate);
                return Employee;
            }
        }
    }
}
