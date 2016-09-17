using MangoSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Data.Context.Config
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<MangoSaleContext>
    {
        protected override void Seed(MangoSaleContext context) 
        {
            new List<Employee>
            {
                new Employee { Name = "Nurul Hadi", Code = "E-01" },
                new Employee { Name = "John Doe", Code = "E-02" }
            }.ForEach(x => context.Employees.Add(x));

            context.SaveChanges();
        }
    }
}
