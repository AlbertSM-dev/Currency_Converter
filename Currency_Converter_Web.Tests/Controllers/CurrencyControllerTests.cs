﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double total3 = currencySelected.CurrencySelectedTotal(4.5, 1000000);

            Assert.IsNotNull(total);
            Assert.IsNotNull(total2);
            Assert.IsNotNull(total3);

            Assert.AreEqual(1.5, total);
            Assert.AreEqual(6, total2);
            Assert.AreEqual(4500000, total3);
        }
    }
}