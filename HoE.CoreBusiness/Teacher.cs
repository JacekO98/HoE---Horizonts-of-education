
namespace HoE.CoreBusiness
{
    public class Teacher
    {
        public string T_ID { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();

        public List<TAvaliable> TAvaliable { get; set; } = new List<TAvaliable> { };

    }
}
