namespace flights_managing
{
    public class Flight
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Airplane Airplane { get; set; }
        public int AirplaneId { get; set; }
        public FlightSchedule Schedule { get; set; }
        public int ScheduleId { get; set; }
        public string GateNumber { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
        public Flight() { }
        public Flight(int id, string number, Airplane airplane, int airplaneId, FlightSchedule schedule, int scheduleId, string gateNumber, Status status, int statusId)
        {
            Id = id;
            Number = number;
            Airplane = airplane;
            AirplaneId = airplaneId;
            Schedule = schedule;
            ScheduleId = scheduleId;
            GateNumber = gateNumber;
            Status = status;
            StatusId = statusId;
        }
    }
}
