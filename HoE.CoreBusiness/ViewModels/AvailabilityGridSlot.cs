namespace HoE.CoreBusiness.ViewModels
{
    public class AvailabilityGridSlot
    {
        public TimeOnly StartTime { get; init; }
        public TimeOnly EndTime { get; init; }
        public bool IsBooked { get; init; }
    }
}
