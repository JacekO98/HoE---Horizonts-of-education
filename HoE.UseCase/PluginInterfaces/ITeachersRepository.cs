using HoE.CoreBusiness;


namespace HoE.UseCase.PluginInterfaces
{
    public interface ITeachersRepository
    {
        Task AddTeacherAsync(Teacher teacher);
        Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name);
        Task ViewTeachersByNameAsync(Teacher teacher);
    }
}