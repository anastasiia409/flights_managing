using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_managing
{
    public class AirportLocation
    {
        public int Id { get; set; }
        public Airport Airport { get; set; }
        public int AirportId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public AirportLocation() { }
        public AirportLocation(int id, Airport airport, int airportId, string country, string city, double latitude, double longitude)
        {
            Id = id;
            Airport = airport;
            AirportId = airportId;
            Country = country;
            City = city;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
