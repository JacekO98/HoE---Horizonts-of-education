using HoE.CoreBusiness;

namespace HoE.UseCase.Teachers.Interfaces
{
    public interface IDeleteTeacherUseCase
    {
        Task ExecuteAsync(Teacher teacher);
    }
}