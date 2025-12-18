using HoE.CoreBusiness;

namespace HoE.UseCase.Teachers.Interfaces
{
    public interface IViewTeachersByIdUseCase
    {
        Task<Teacher> ExecuteAsync(int T_ID);
    }
}