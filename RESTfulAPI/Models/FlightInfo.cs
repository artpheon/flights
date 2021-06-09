using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;
using RESTfulAPI.Models;

namespace RESTfulAPI.Util
{
    public class FlightParser
    {
        public Flight GetFlightById(int id)
        {
            var flights = this.Parse();
            return flights.FirstOrDefault(f => f.Id == id);
        }
        public Flight[] Parse()
        {
            var engine = new FileHelperEngine<Flight>();
            string path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/flights.csv");
            return engine.ReadFile(path);
        }
    }
}