using HoE.CoreBusiness;

namespace HoE.UseCase.Teachers.Interfaces
{
    public interface IViewTeachersByNameUseCase
    {
        Task<IEnumerable<Teacher>> ExecuteAsync(string name = "");
    }
}