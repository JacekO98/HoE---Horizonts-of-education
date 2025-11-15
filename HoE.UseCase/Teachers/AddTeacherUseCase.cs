using HoE.UseCase.PluginInterfaces;
using HoE.CoreBusiness;
using HoE.UseCase.Teachers.Interfaces;

namespace HoE.UseCase.Teachers
{
    public class AddTeacherUseCase : IAddTeacherUseCase
    {
        private readonly ITeachersRepository teachersRepository;

        public AddTeacherUseCase(ITeachersRepository teachersRepository)
        {
            this.teachersRepository = teachersRepository;
        }

        public async Task ExecuteAsync(Teacher teacher)
        {
            await this.teachersRepository.AddTeacherAsync(teacher);
        }
    }
}
