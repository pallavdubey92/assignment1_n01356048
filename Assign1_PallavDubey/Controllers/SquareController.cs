using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_PallavDubey.Controllers
{
    public class SquareController : ApiController
    {
        // GET: api/square/{id}
        // returns square of input
        public int Get(int id)
        {
            return id * id;
        }
    }
}
