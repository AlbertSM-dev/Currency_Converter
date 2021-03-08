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

            Assert.AreEqual(1.5, total);
            Assert.IsNotNull(total);
            
        }
    }
}