using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoE.CoreBusiness
{
    internal class AvaliabilitySlot
    {
        //Tu może być problem z typami danych bo robię inaczej niż chat
        public int Avaliable_ID { get; private set; }
        public int T_ID { get; private set; }
        public DateOnly StartDate { get; private set; }
        public TimeOnly StartTime { get; private set; }
        public TimeOnly EndTime { get; private set; }

        public AvaliabilitySlot(int t_ID, DateOnly startTime, TimeOnly endTime)
        {
 
            int T_ID = t_ID;
            DateOnly StartTime = startTime;
            TimeOnly EndTime = endTime;

        }


    }
}
