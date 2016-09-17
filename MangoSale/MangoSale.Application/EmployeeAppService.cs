using MangoSale.Application.Interface;
using MangoSale.Common.Application;
using MangoSale.Common.Domain.Validation;
using MangoSale.Data.Context;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Application
{
    public class EmployeeAppService : AppService<MangoSaleContext>, IEmployeeAppService
    {
        private readonly IEmployeeService _service;

        public EmployeeAppService(IEmployeeService employeeService)
        {
            _service = employeeService;
        }

        public ValidationResult Create(Employee employee)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(employee));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Employee employee)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(employee));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Employee employee)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(employee));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Employee Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Employee> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Employee> Find(Expression<Func<Employee, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
