using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain.Tests
{
    [TestClass]
    public class SaleLineItemTest
    {
        [TestMethod]
        public void changing_product_price_should_not_change_sli_subtotal()
        {
            var sli = new SaleLineItem();
            var m = Samples.Momogi;
            sli.Quantity = 2;
            sli.Product = m;
            Assert.AreEqual(1000m, sli.GetSubtotal());

            m.UnitPrice = 0;
            Assert.AreEqual(1000m, sli.GetSubtotal());
        }
    }
}
