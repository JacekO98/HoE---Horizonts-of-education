using HoE.CoreBusiness;

namespace HoE.UseCase.Students.Interfaces
{
    public interface IViewStudentsByNameUseCase
    {
        Task<IEnumerable<Student>> ExecuteAsync(string name = "");
    }
}