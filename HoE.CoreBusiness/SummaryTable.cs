using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoE.CoreBusiness
{
    public class SummaryTable
    {
        public string T_ID { get; set; }
        public Teacher Teacher { get; set; }

        public string L_ID { get; set; }
        public Level Level { get; set; }

        public string S_ID { get; set; }
        public Student Student { get; set; }


        public string K_ID { get; set; }
        public Kalendar Kalendar { get; set; }
    }
}
