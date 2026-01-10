using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;
using HoE.UseCase.TAvaliable.Interfaces;

namespace HoE.UseCase.TAvaliable
{
    public class TeacherBookSlot : ITeacherBookSlot
    {
        private readonly ITAvaliableNewRepository _tAvaliableNewRepository;

        public TeacherBookSlot(ITAvaliableNewRepository _tAvaliableNewRepository)
        {
            _tAvaliableNewRepository = _tAvaliableNewRepository;
        }

        public async Task ExecuteAsync(int T_ID, DateOnly StartDate, TimeOnly StartTime)
        {
            var existingSlot = await _tAvaliableNewRepository.GetSlot(T_ID, StartDate, StartTime);
            var pickedSlot = existingSlot.FirstOrdefault(s => s.StartDate = StartDate);

            if (pickedSlot != null)
            {
                await _tAvaliableNewRepository.DeteleSlotAsync(pickedSlot.Avaliable_ID);
            }
            else
            {
                var newSlot = new TAvaliableNew(T_ID, StartDate, StartTime);
                await _tAvaliableNewRepository.AddSlot(newSlot);
            }

        }


    }
}