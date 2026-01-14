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
        Task DeteleSlotAsync(TAvaliableNew tAvaliableNew);
        Task<TAvaliableNew> GetSlot(int t_ID, DateOnly startDate, TimeOnly startTime);
    }
}
