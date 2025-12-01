
namespace HoE.CoreBusiness
{
    public class TLevels
    {
        public string T_ID { get; set; }

        public string L_ID { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();
    }
}
