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

        public TAvaliableNewRepository()
        {
            _avaliableNews = new List<TAvaliableNew>()
            {
                new TAvaliableNew { Avaliable_ID = 1, T_ID = 01, StartDate = new DateOnly(2025, 1, 10), StartTime = new TimeOnly(14, 30), EndTime = new TimeOnly(15, 30) }
            };

        }
        //W poniższych metodach trzeba będzie sprawdzić czy nie lepiej używać ID i na tej podstawie operować rekordami
        public Task AddSlot(TAvaliableNew newSlot)
        {
            _avaliableNews.Add(newSlot);
            return Task.CompletedTask;
        }

        public Task<TAvaliableNew?> CheckExistingSlotAsync(TAvaliableNew tAvaliableNew)
        {
            var existingSlot = _avaliableNews.FirstOrDefault(a => a.T_ID == tAvaliableNew.T_ID && a.StartDate == tAvaliableNew.StartDate && a.StartTime == tAvaliableNew.StartTime);
            return Task.FromResult(existingSlot);
        }
        //Przeanalizować metode Delete jeszcze raz
        public Task DeleteSlotAsync(TAvaliableNew slot)
        {
            var toRemove = _avaliableNews.FirstOrDefault(a => a.Avaliable_ID == slot.Avaliable_ID);
            if (toRemove != null)
                _avaliableNews.Remove(toRemove);

            return Task.CompletedTask;
        }

        public Task<List<TAvaliableNew>> GetBookedSlots(int T_ID, DateOnly startD, DateOnly endD)
        {
            var bookedSlotsList = new List<TAvaliableNew>();
            for (var day = startD; day <= endD; day = day.AddDays(1))
            {
                var bookedDaySlot = _avaliableNews.Where(s =>
                s.T_ID == T_ID &&
                s.StartDate == day);
                bookedSlotsList.AddRange(bookedDaySlot);
                            

            }
            
            return Task.FromResult(bookedSlotsList);
        }

        public Task<TAvaliableNew> GetSlot(int t_ID, DateOnly startDate, TimeOnly startTime)
        {
            throw new NotImplementedException();
        }

        
    }
}
