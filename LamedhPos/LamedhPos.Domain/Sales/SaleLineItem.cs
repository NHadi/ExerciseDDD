using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class SaleLineItem : EntityBase
    {
        private Product product;

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Product Product 
        {
            get { return product; }
            set
            {
                product = value;
                UnitPrice = value.UnitPrice;
            }
        }

        public decimal GetSubtotal()
        {
            return UnitPrice * Quantity;
        }
    }
}
