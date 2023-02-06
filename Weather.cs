using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_managing
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double Temperature { get; set; } 
        public double Humidity { get; set; }
        public double Airpressure { get; set; }
        public double WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public AirportLocation Location { get; set; }
        public int AirportLocationId { get; set; }
        public Weather() { }
        public Weather(int id, DateTime time, double temperature, double humidity, double airpressure, double windSpeed, string windDirection, AirportLocation location, int airportLocationId)
        {
            Id = id;
            Time = time;
            Temperature = temperature;
            Humidity = humidity;
            Airpressure = airpressure;
            WindSpeed = windSpeed;
            WindDirection = windDirection;
            Location = location;
            AirportLocationId = airportLocationId;
        }
    }
}
