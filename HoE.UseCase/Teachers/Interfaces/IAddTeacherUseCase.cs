namespace HoE.UseCase.Teachers.Interfaces
{
    public interface IAddTeacherUseCase
    {
        Task ExecuteAsync(Teacher teacher);
    }
}