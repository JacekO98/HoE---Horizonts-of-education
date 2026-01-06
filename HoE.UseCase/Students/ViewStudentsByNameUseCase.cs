using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.UseCase.PluginInterfaces;
using HoE.CoreBusiness;
using HoE.UseCase.Students.Interfaces;


namespace HoE.UseCase.Students
{
    public class ViewStudentsByNameUseCase : IViewStudentsByNameUseCase
    {
        private readonly IStudentsRepository studentRepository;

        public ViewStudentsByNameUseCase(IStudentsRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> ExecuteAsync(string name = "")
        {
            return await studentRepository.GetStudentsByNameUseCase(name);
        }
    }


}
