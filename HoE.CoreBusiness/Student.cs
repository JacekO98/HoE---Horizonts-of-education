
namespace HoE.CoreBusiness
{
    public class Student
    {
        public string S_ID { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();
    }
}
