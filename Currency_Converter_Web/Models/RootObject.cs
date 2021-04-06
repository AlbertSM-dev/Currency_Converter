﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter_Web.Models
{

    public class Rates
    {
        public double CAD { get; set; }
        public double HKD { get; set; }
        public double ISK { get; set; }
        public double PHP { get; set; }
        public double DKK { get; set; }
        public double HUF { get; set; }
        public double CZK { get; set; }
        public double AUD { get; set; }
        public double RON { get; set; }
        public double SEK { get; set; }
        public double IDR { get; set; }
        public double INR { get; set; }
        public double BRL { get; set; }
        public double RUB { get; set; }
        public double HRK { get; set; }
        public double JPY { get; set; }
        public double THB { get; set; }
        public double CHF { get; set; }
        public double SGD { get; set; }
        public double PLN { get; set; }
        public double BGN { get; set; }
        public double TRY { get; set; }
        public double CNY { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double ZAR { get; set; }
        public double USD { get; set; }
        public double MXN { get; set; }
        public double ILS { get; set; }
        public double GBP { get; set; }
        public double KRW { get; set; }
        public double MYR { get; set; }
    }

    public class RootObject
    {
        private int quantity;
        public int Quantity
        {
            get 
            {
                if (quantity == 0) { return 1; }
                else { return quantity; }
            }
            set
            {
                quantity = value;
            }
        }
        //public int Quantity { get; set; }
        public string To { get; set; }
        public Rates rates { get; set; }
        public string Base { get; set; }
        public string Date { get; set; }
    }
}
