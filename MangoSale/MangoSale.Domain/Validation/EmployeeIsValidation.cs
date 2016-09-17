using MangoSale.Common.Domain.Validation;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Specifications.EmployeeSpecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Domain.Validation
{
    public class EmployeeIsValidation : Validation<Employee>
    {
        public EmployeeIsValidation()
        {
            base.AddRule(new ValidationRule<Employee>(new EmployeeCodeIsRequiredSpec(), ValidationMessages.NameIsRequired));
            base.AddRule(new ValidationRule<Employee>(new EmployeeNameIsRequiredSpec(), ValidationMessages.CodeIsRequired));
        }
    }
}
