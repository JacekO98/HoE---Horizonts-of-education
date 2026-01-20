using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;

namespace HoE.UseCase.PluginInterfaces
{
    public interface ITAvaliableNewRepository
    {
        Task AddSlot(TAvaliableNew newSlot);
        Task<TAvaliableNew?> CheckExistingSlotAsync(TAvaliableNew tAvaliableNew);
        public Task DeleteSlotAsync(TAvaliableNew slot);
        Task GetBookedSlots(int t_ID, DateOnly startD);
        Task<TAvaliableNew> GetSlot(int t_ID, DateOnly startDate, TimeOnly startTime);
    }
}
