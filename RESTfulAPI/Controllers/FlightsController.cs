using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfulAPI.Util;

namespace RESTfulAPI.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return NotFound();
        }

        public IHttpActionResult Get(int id)
        {
            FlightParser parser = new FlightParser();
            var flight = parser.GetFlightById(id);
            if (flight == null)
                return NotFound();
            return Json(flight);
        }

        public void Post([FromBody] string value)
        {
        }

        public void Put(int id, [FromBody] string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
