using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_PallavDubey.Controllers
{
    public class GreetingController : ApiController
    {
        // Get: api/Greeting
        // returns "Hello World"
        public string Get()
        {
            return "Hello World";
        }

        // Get: api/greeting/{id}
        // return Greeting to {id} people!
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
