using HoE.CoreBusiness;


namespace HoE.UseCase.PluginInterfaces
{
    public interface ITeachersRepository
    {
        Task AddTeacherAsync(Teacher teacher);
        
    }
}