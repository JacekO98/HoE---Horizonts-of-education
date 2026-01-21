using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;
using HoE.CoreBusiness.ViewModels;
using HoE.UseCase.TAvaliable.Interfaces;

namespace HoE.UseCase.TAvaliable
{
    public class GetTeacherAvailabilityGridUseCase : IGetTeacherAvailabilityGridUseCase
    {
        private readonly ITAvaliableNewRepository tAvaliableNewRepository;

        public GetTeacherAvailabilityGridUseCase(ITAvaliableNewRepository tAvaliableNewRepository)
        {
            this.tAvaliableNewRepository = tAvaliableNewRepository;
        }
        public async Task<List<AvailabilityGridDay>> ExecuteAsync(int T_ID)
        {
            var startD = DateOnly.FromDateTime(DateTime.Today);
            var endD = startD.AddDays(7);
            var results = new List<AvailabilityGridDay>();
            var bookedSlots = await tAvaliableNewRepository.GetBookedSlots(T_ID, startD, endD);

            for (var date = startD; date <= endD; date = date.AddDays(1))
            {
                var startT = new TimeOnly(7, 0);
                var endT = new TimeOnly(22, 0);
                var daySlots = new List<AvailabilityGridSlot>();

                while (startT < endT)
                {
                    var isBooked = bookedSlots.Any(b => 
                    b.StartDate == date &&
                    b.StartTime == startT);

                    daySlots.Add(new AvailabilityGridSlot
                    {
                        StartTime = startT,
                        EndTime = startT.AddMinutes(30),
                        IsBooked = isBooked
                    });

                    startT = startT.AddMinutes(30);
                }
                results.Add(new AvailabilityGridDay
                {
                    Date = date,
                    Slots = daySlots
                });
            }
            return results;
        }
    }
}
