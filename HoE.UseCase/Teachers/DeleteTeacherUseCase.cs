using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.Teachers.Interfaces;
using HoE.UseCase.PluginInterfaces;

namespace HoE.UseCase.Teachers
{
    public class DeleteTeacherUseCase : IDeleteTeacherUseCase
    {
        private readonly ITeachersRepository teachersRepository;

        public DeleteTeacherUseCase (ITeachersRepository teachersRepository)
        {
            this.teachersRepository = teachersRepository;
        }
        public async Task ExecuteAsync(Teacher teacher)
        {
            await this.teachersRepository.DeleteTeacherAsync(teacher);
        }
    }
}
