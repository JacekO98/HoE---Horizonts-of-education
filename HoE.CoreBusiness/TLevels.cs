
using System.ComponentModel.DataAnnotations;

namespace HoE.CoreBusiness
{
    public class TLevels
    {
        [Key]
        public int T_ID { get; set; }

        
        public int L_ID { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();
    }
}
