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
        private readonly ITAvaliableNewRepository tAvaliableNewRepository;

        public TeacherBookSlot(ITAvaliableNewRepository tAvaliableNewRepository)
        {
            this.tAvaliableNewRepository = tAvaliableNewRepository;
        }

        public async Task ExecuteAsync(TAvaliableNew tAvaliableNew)
        {
            var existingSlot =
                await tAvaliableNewRepository.CheckExistingSlotAsync(tAvaliableNew);


            if (existingSlot != null)
            {
                await tAvaliableNewRepository.DeleteSlotAsync(existingSlot);
            }
            else
            {
                
                await tAvaliableNewRepository.AddSlot(tAvaliableNew);
            }

        }


    }
}