using HoE.CoreBusiness.ViewModels;

namespace HoE.Components.ViewModels
{
    public class AvailabilityGridDayViewModel
    {
        public DateOnly Date { get; set; }
        public List<AvailabilityGridSlotViewModel> Slots { get; set; }
        
    }
}
