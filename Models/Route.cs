namespace IntroToApi.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccesible { get; set; }
        public bool BicycleAccesible { get; set; }
        public Queue<ScheduledStop> StopSchedule { get; set; }
    }
}
