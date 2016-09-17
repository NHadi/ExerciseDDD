using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class Samples
    {
        public static Employee Suyama
        {
            get
            {
                return new Employee { Id = 1, Code = "E01", Name = "Michael Suyama", Birthdate = DateTime.Now.AddYears(-40) };
            }
        }

        public static Employee Nancy
        {
            get
            {
                return new Employee { Id = 2, Code = "E02", Name = "Nancy Davolio", Birthdate = DateTime.Now.AddYears(-30), };
            }
        }

        public static Product Momogi
        {
            get 
            {
                return new Product { Id = 1, Code = "P01", Name = "Momogi", UnitPrice = 500m };
            }
        }

        public static Product Pepsi
        {
            get 
            {
                return new Product { Id = 2, Code = "P02", Name = "Pepsi", UnitPrice = 5000m };
            }
        }

    }
}
