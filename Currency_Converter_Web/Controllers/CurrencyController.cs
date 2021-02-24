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
        //[HttpPost]
        public IActionResult Index(Models.RootObject x)
        {
            //POST
            //int Number = x.Quantity;
            //string currencySelected = x.To;
            //double currencyChange = 0;
            CurrencySelected currencyST = new CurrencySelected();
            //URL json
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://api.exchangeratesapi.io/latest");
            Models.RootObject objJson = JsonConvert.DeserializeObject<Models.RootObject>(json);
            //Currency Selected and Change
           /* if (currencySelected == "USD") { currencyChange = objJson.rates.USD; }
            else if (currencySelected == "GBP") { currencyChange = objJson.rates.GBP; }
            else if (currencySelected == "CAD") { currencyChange = objJson.rates.CAD; }
            else if (currencySelected == "AUD") { currencyChange = objJson.rates.AUD; }*/
            //Return total and selected
            ViewBag.Selected = x.To;
            ViewBag.Total = currencyST.CurrrencySelectedTotal(x.Quantity, Convert.ToDouble(x.To));
            //ViewBag.Total = Math.Round(Number * x.CurrrencySelectedTotal(currencySelected), objJson.rates);
            return View(objJson);
        }

    }

    public class CurrencySelected
    {
        public double CurrrencySelectedTotal(double quantity, double to)
        {
            return Math.Round(quantity * to, 4);
        }
    }
}