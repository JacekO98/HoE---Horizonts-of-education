using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoE.CoreBusiness
{
    public class TAvaliableNew
    {
        //Tu może być problem z typami danych bo robię inaczej niż chat
        public int Avaliable_ID { get; set; }
        public int T_ID { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

      


    }
}
