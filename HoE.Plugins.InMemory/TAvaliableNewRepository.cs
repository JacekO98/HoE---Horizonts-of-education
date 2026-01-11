using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;

namespace HoE.Plugins.InMemory
{
    public class TAvaliableNewRepository : ITAvaliableNewRepository
    {
        private List<TAvaliableNew> _avaliableNews;

        TAvaliableNewRepository()
        {
            _avaliableNews = new List<TAvaliableNew>()
            {
                new TAvaliableNew { Avaliable_ID = 1, T_ID = 01, StartDate = new DateOnly(2025, 1, 10), StartTime = new TimeOnly(14, 30), EndTime = new TimeOnly(15, 30) }
            };

        }

        public Task AddSlot(TAvaliableNew newSlot)
        {
            throw new NotImplementedException();
        }

        
        public Task DeteleSlotAsync(object avaliable_ID)
        {
            throw new NotImplementedException();
        }

        public Task<TAvaliableNew> GetSlot(int t_ID, DateOnly startDate, TimeOnly startTime)
        {
            throw new NotImplementedException();
        }
    }
}
