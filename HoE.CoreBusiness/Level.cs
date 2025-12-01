
namespace HoE.CoreBusiness
{
    public class Level
    {
        public string T_ID { get; set; }

        public string SchoolType { get; set; }

        public int Klass { get; set; }

        public string Subject { get; set; }

        public string Levels { get; set; }

        public int Cost { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();
    }
}
