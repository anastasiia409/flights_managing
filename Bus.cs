
namespace flights_managing
{
    public class Bus
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public bool NeedRepairment { get; set; }
        public Bus() { }
        public Bus(int id, string model, bool needRepairment)
        {
            Id = id;
            Model = model;
            NeedRepairment = needRepairment;
        }
    }
}
