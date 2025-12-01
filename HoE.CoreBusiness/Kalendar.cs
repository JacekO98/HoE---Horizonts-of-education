namespace HoE.CoreBusiness
{
    public class Kalendar
    {
        public string K_ID { get; set; }

        public DateTime Date_Time { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();

        public List<TAvaliable> TAvaliable { get; set; } = new List<TAvaliable> { };
    }
}
