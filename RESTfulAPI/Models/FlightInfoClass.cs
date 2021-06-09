using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;
using Newtonsoft.Json;

namespace RESTfulAPI.Models
{
	[DelimitedRecord(","), IgnoreFirst(), IgnoreEmptyLines()]
	public class Flight
	{
		[JsonIgnore]
		public int Id;

		[JsonIgnore]
		public string Origin;

		[JsonIgnore]
		public string Destination;

		[JsonIgnore]
		public string DepartureDate;

		[JsonProperty(Order = 2)]
		public string DepartureTime;

		[JsonIgnore]
		public string ArrivalDate;

		[JsonProperty(Order = 3)]
		public string ArrivalTime;

		[JsonProperty(Order = 1)]
		public string Number;

	}
}