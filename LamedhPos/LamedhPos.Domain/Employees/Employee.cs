using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class Employee : EntityBase
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
    }
}
