namespace HoE.CoreBusiness.ViewModels
{
    public class AvailabilityGridDay
    {
        public DateOnly Date { get; init; }
        public List<AvailabilityGridSlot> Slots { get; init; } = [];
    }
}
