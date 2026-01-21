using HoE.CoreBusiness.ViewModels;

namespace HoE.UseCase.TAvaliable.Interfaces
{
    public interface IGetTeacherAvailabilityGridUseCase
    {
        Task<List<AvailabilityGridDay>> ExecuteAsync(int T_ID);
    }
}