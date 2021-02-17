using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency_Converter_Web.Helpers;

namespace Currency_Converter_Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var currencySelected = new CurrencySelected();
            double total = currencySelected.CurrrencySelectedTotal(1, 1.5);

            Assert.IsNotNull(total);
        }
    }
}
