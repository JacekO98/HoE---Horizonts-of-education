
using System.ComponentModel.DataAnnotations;

namespace HoE.CoreBusiness
{
    public class StudentViewModel
    {
        [Key]
        public int S_ID { get; set; }

        public string Name { get; set; }

        
    }
}
