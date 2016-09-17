using MangoSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Data.Context.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            HasKey(x => x.Id);

            // Properties
            Property(x => x.Code)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.Birthdate);

            Property(x => x.Age);

            Ignore(x => x.ValidationResult);
        }
    }
}
