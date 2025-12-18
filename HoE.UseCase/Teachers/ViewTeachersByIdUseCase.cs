using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;
using HoE.UseCase.Teachers.Interfaces;

namespace HoE.UseCase.Teachers
{
    public class ViewTeachersByIdUseCase : IViewTeachersByIdUseCase
    {
        private readonly ITeachersRepository teachersRepository;

        public ViewTeachersByIdUseCase(ITeachersRepository teachersRepository)
        {
            this.teachersRepository = teachersRepository;
        }

        public async Task<Teacher> ExecuteAsync(int T_ID)
        {
            return await teachersRepository.ViewTeachersByIdUseCase(T_ID);
        }
    }
}
