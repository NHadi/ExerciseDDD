using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class Sale : EntityBase
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }

        public Employee Cashier { get; set; }
        public IList<SaleLineItem> LineItems { get; private set; }

        public Sale()
        {
            LineItems = new List<SaleLineItem>();
            Time = DateTime.Now;
        }

        public decimal GetTotal()
        {
            return LineItems.Sum(sli => sli.GetSubtotal());
        }

        public void AddLineItem(Product product, int quantity = 1)
        {
            SaleLineItem lineItem = GetLineItem(product);
            if (lineItem == null)
            {
                lineItem = new SaleLineItem { Product = product, };
                LineItems.Add(lineItem);
            }
            lineItem.Quantity += quantity;
        }

        public SaleLineItem GetLineItem(Product product)
        {
            foreach (var sli in LineItems)
                if (sli.Product.Equals(product))
                    return sli;
            return null;
        }
    }
}
