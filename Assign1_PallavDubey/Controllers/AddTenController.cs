using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_PallavDubey.Controllers
{
    public class AddTenController : ApiController
    {
        // get: api/addten/{id}
        // adds 10 to the input
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
