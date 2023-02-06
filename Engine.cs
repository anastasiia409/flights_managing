namespace flights_managing
{
    public class Engine
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public bool NeedRepairment { get; set; }
        public DateOnly DateOfExploitation { get; set; }
        public Engine() { }
        public Engine(int id, string model, bool needRepairment, DateOnly dateOfExploitation)
        {
            Id = id;
            Model = model;
            NeedRepairment = needRepairment;
            DateOfExploitation = dateOfExploitation;
        }
    }
}
