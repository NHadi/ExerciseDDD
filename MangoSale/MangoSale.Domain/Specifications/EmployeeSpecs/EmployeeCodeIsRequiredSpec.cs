using MangoSale.Common.Domain.Specifications;
using MangoSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Domain.Specifications.EmployeeSpecs
{
    public class EmployeeCodeIsRequiredSpec : ISpecification<Employee>
    {
        public bool IsSatisfiedBy(Employee employee)
        {
            return !String.IsNullOrEmpty(employee.Code) && !String.IsNullOrWhiteSpace(employee.Code);
        }
    }
}
