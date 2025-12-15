using HoE.CoreBusiness;
namespace HoE.UseCase.PluginInterfaces
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<Student>> GetStudentsByNameUseCase(string name);
    }
}