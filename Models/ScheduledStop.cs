namespace IntroToApi.Models
{
    public class ScheduledStop
    { 
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public IntroToApi.Models.Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
