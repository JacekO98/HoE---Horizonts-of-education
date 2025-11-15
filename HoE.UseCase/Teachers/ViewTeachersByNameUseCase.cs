using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.UseCase.PluginInterfaces;
using HoE.CoreBusiness;
using HoE.UseCase.Teachers.Interfaces;

namespace HoE.UseCase.Teachers
{
    public class ViewTeachersByNameUseCase : IViewTeachersByNameUseCase
    {
        internal ITeachersRepository teacherRepository;

        public ViewTeachersByNameUseCase(ITeachersRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public async Task<IEnumerable<Teacher>> ExecuteAsync(string name = "")
        {
            return await teacherRepository.GetTeachersByNameAsync(name); 
        }
    }
}
