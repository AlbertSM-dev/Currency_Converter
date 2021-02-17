using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using Currency_Converter_Web.Models;

namespace Currency_Converter_Web.Helpers
{
    public class CurrencySelected
    {
        public double CurrrencySelectedTotal(int quantity, double currency)
        {
            return quantity * currency;
        }
    }
}
