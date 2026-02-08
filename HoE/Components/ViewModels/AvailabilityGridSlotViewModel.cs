namespace HoE.Components.ViewModels
{
    public class AvailabilityGridSlotViewModel
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsBooked { get; set; }
    }
}
