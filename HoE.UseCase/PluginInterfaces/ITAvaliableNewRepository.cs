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
        Task DeteleSlotAsync(object avaliable_ID);
        Task<TAvaliableNew> GetSlot(int t_ID, DateOnly startDate, TimeOnly startTime);
    }
}
