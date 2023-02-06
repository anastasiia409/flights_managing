namespace flights_managing
{
    public class Terminal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Airport Airport { get; set; }
        public int AirportId { get; set; }
        public Terminal() { }
        public Terminal(int id,  string name, Airport airport, int airportId)
        {
            Id = id;
            Name = name;
            Airport = airport;
            AirportId = airportId;
        }
    }
}
