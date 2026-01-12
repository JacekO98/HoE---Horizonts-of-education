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

        public async Task ExecuteAsync(TAvaliableNew tAvaliableNew)
        {           
            

            if (_tAvaliableNewRepository.CheckExistingSlotAsync(tAvaliableNew) != null)
            {
                await _tAvaliableNewRepository.DeteleSlotAsync(tAvaliableNew.Avaliable_ID);
            }
            else
            {
                
                await _tAvaliableNewRepository.AddSlot(tAvaliableNew);
            }

        }


    }
}