using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_PallavDubey.Controllers
{
    public class HostingCostController : ApiController
    {
        public string[] Get(int id)
        {
            double costPerFortNight = 5.5;

            int noOfFortNights = id / 14;
            int extraDays = id % 14;

            if (extraDays >= 0)
            {
                noOfFortNights += 1;
            }

            double cost = noOfFortNights * costPerFortNight;
            double hst = 0.13 * cost;

            cost = Math.Round(cost, 2);
            hst = Math.Round(hst, 2);

            string costString = noOfFortNights + " fortnights at $5.50/FN = $" + cost + " CAD";
            string hstString = "HST 13% = $" + hst + " CAD";
            string totalString = "Total = $" + (cost + hst) + " CAD";

            return new string[] {
                costString,
                hstString,
                totalString
            };
        }
    }
}
