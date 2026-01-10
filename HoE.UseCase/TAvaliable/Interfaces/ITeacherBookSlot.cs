namespace HoE.UseCase.TAvaliable.Interfaces
{
    public interface ITeacherBookSlot
    {
        Task ExecuteAsync(int T_ID, DateOnly StartDate, TimeOnly StartTime);
    }
}