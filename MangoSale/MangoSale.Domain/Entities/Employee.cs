using MangoSale.Common.Domain;
using MangoSale.Common.Domain.Validation;
using MangoSale.Common.Domain.Validation.Interface;
using MangoSale.Domain.Validation;
using System;

namespace MangoSale.Domain.Entities
{
    public class Employee : EntityBase, ISelfValidation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - Birthdate.Year; }
        }

        public Employee()
        {
            Birthdate = DateTime.Now.AddYears(-25);
        }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new EmployeeIsValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
