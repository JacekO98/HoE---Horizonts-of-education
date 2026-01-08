using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.UseCase.PluginInterfaces;

namespace HoE.UseCase.TAvaliables
{
    public class TeacherBookSlot
    {
        private readonly ITAvaliableRepository _tAvaliableRepository;

        public TeacherBookSlot(ITAvaliableRepository _tAvaliableRepository)
        {
            _tAvaliableRepository = tAvaliableRepository;
        }

        public async Task ExecuteAsync(int T_ID, DateOnly StartDate, TimeOnly StartTime)
        {
            var existingSlot = await _tAvaliableRepository.GetSlot(int T_ID, DateOnly StartDate, TimeOnly StartTime);
            var pickedSlot = existingSlot.FirstOrdefault(s => s.StartDate =  StartDate);

            if (pickedSlot != null)
            {
                await _tAvaliableRepository.DeteleSlotAsync(pickedSlot.Avaliable_ID);
            }
            else
            {
                var newSlot = new TAvaliableNew(T_ID, StartDate, StartTime);
                await _tAvaliableRepository.AddSlot(newSlot);
            }

        }


    }
}