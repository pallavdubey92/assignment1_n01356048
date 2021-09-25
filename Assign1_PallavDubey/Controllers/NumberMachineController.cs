using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_PallavDubey.Controllers
{
    public class NumberMachineController : ApiController
    {
        // get: api/numbermachine/{id}
        // applies 4 math operations
        public int Get(int id)
        {
            int timesFour = id * 4;
            int subTen = timesFour - 10;
            int half = subTen / 2;
            int num = half + 1;

            return num;
        }
    }
}
