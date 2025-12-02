
using System.ComponentModel.DataAnnotations;

namespace HoE.CoreBusiness
{
    public class TAvaliable
    {
        [Key]
        public int T_ID { get; set; }

        public Teacher Teacher { get; set; }

        [Key]
        public int K_ID { get; set; }

        public Kalendar Kalendar { get; set; }
    }
}
