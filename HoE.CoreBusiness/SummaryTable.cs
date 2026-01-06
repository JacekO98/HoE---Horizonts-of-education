using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoE.CoreBusiness
{
    public class SummaryTable
    {
        [Key]
        public int T_ID { get; set; }
        public Teacher Teacher { get; set; }

        [Key]
        public int L_ID { get; set; }
        public Level Level { get; set; }

        [Key]
        public int S_ID { get; set; }
        public Student Student { get; set; }

        [Key]

        public int K_ID { get; set; }
        public Kalendar Kalendar { get; set; }
    }
}
