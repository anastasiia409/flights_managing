namespace flights_managing
{
    public class FlightSchedule
    {
        public int Id { get; set; }
        public int FLightId { get; set; }
        public Flight Flight { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public FlightSchedule() { }
        public FlightSchedule(int id, int fLightId, Flight flight, DateTime departureTime, DateTime arrivalTime, string departure, string destination)
        {
            Id = id;
            FLightId = fLightId;
            Flight = flight;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Departure = departure;
            Destination = destination;
        }
    }
}
