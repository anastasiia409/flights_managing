using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_managing
{
    public  class Ticket
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
        public Flight Flight { get; set; }
        public int FlightId { get; set; }
        public string Seat { get; set; }
        public Ticket() { }
        public Ticket(int id, Passenger passenger, int passengerId, Flight flight, int flightId, string seat)
        {
            Id = id;
            Passenger = passenger;
            PassengerId = passengerId;
            Flight = flight;
            FlightId = flightId;
            Seat = seat;
        }
    }
}
