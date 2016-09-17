using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class Product : EntityBase
    {
        private decimal unitPrice;

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice 
        {
            get { return unitPrice; }
            set
            {
                if (value >= 0)
                    unitPrice = value;
            } 
        }
    }
}
