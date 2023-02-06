using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_managing
{
    public class Status
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public FlightSchedule NewSchedule { get;set; }
        public int NewScheduleId { get; set; }
        public Status() { }
        public Status(int id, string statusName, FlightSchedule newSchedule, int newScheduleId)
        {
            Id = id;
            StatusName = statusName;
            NewSchedule = newSchedule;
            NewScheduleId = newScheduleId;
        }
    }
}
