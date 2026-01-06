
using System.ComponentModel.DataAnnotations;

namespace HoE.CoreBusiness
{
    public class Student
    {
        [Key]
        public int S_ID { get; set; }

        public string Name { get; set; }

        public List<SummaryTable> SummaryTable { get; set; } = new List<SummaryTable>();
    }
}
