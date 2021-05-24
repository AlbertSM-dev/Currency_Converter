using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using Currency_Converter_Web.Models;

namespace Currency_Converter_Web.Controllers
{

    public class CurrencyController : Controller
    {
        
        public IActionResult Index(Models.RootObject x)
        {
            CurrencySelected currencySelect = new CurrencySelected();

            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"http://api.exchangeratesapi.io//v1/latest?access_key=a8047f7531cca2d853eef972c87d3c43");
            Models.RootObject objJson = JsonConvert.DeserializeObject<Models.RootObject>(json);

            ViewBag.Selected = x.To;
            ViewBag.Total = currencySelect.CurrencySelectedTotal(x.Quantity, Convert.ToDouble(x.To));

            return View(objJson);
        }

    }

    public class CurrencySelected
    {
        public double CurrencySelectedTotal(double quantity, double to)
        {
            return Math.Round(quantity * to, 4);
        }
    }
}