using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models
{
    public class Billing
    {
        public int rentalBill { get; set; }
        public readonly int TaxRate = 18;
        public double TotalBill { get; set; }
    }
}