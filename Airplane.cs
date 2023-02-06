namespace flights_managing
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int EngineId { get; set; }
        public DateOnly DateOfExploitation { get; set; }
        public int Capacity { get; set; }
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
        public Airplane() { }
        public Airplane(int id, string model, Engine engine, int engineId, DateOnly dateOfExploitation, int capacity, Airline airline, int airlineId)
        {
            Id = id;
            Model = model;
            Engine = engine;
            EngineId = engineId;
            DateOfExploitation = dateOfExploitation;
            Capacity = capacity;
            Airline = airline;
            AirlineId = airlineId;
        }
    }
}
