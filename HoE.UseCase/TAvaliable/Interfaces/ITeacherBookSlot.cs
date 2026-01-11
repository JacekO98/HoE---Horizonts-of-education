using HoE.CoreBusiness;

namespace HoE.UseCase.TAvaliable.Interfaces
{
    public interface ITeacherBookSlot
    {
        Task ExecuteAsync(TAvaliableNew tAvaliableNew);
    }
}