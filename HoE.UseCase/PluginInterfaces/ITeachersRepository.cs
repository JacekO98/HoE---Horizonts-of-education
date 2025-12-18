using HoE.CoreBusiness;


namespace HoE.UseCase.PluginInterfaces
{
    public interface ITeachersRepository
    {
        Task AddTeacherAsync(Teacher teacher);
        Task DeleteTeacherAsync(Teacher teacher);
        Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name);
        Task<Teacher> ViewTeachersByIdUseCase(int t_ID);
        Task ViewTeachersByNameAsync(Teacher teacher);
    }
}