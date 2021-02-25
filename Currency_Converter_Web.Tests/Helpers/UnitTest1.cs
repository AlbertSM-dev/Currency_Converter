using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency_Converter_Web.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Currency_Converter_Web.Helpers.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void CurrrencySelectedTotalTest()
        {
            var currencySelected = new CurrencySelected();
            double total = currencySelected.CurrrencySelectedTotal(1, 1.5);

            Assert.AreEqual(1.5, total);
        }
    }
}