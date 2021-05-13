using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency_Converter_Web.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Currency_Converter_Web.Controllers.Tests
{
    [TestClass()]
    public class CurrencyControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {

            var currencySelected = new CurrencySelected();
            double total = currencySelected.CurrencySelectedTotal(1, 1.5);
            double total2 = currencySelected.CurrencySelectedTotal(4, 1.5);
            double total3 = currencySelected.CurrencySelectedTotal(4.5, 100000);
            double total4 = currencySelected.CurrencySelectedTotal(0, 0);
            double total5 = currencySelected.CurrencySelectedTotal(1, 1);

            Assert.IsNotNull(total);
            Assert.IsNotNull(total2);
            Assert.IsNotNull(total3);
            Assert.IsNotNull(total4);
            Assert.IsNotNull(total5);

            Assert.AreEqual(1.5, total);
            Assert.AreEqual(6, total2);
            Assert.AreEqual(450000, total3);
            Assert.AreEqual(0, total4);
            Assert.AreEqual(1, total5);
        }
    }
}