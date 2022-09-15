namespace IntroToApi.Models
{
    public class Stop
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public List<ScheduledStop> StopSchedules { get; set; }

    }
}
