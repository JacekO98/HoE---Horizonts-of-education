
using System.ComponentModel.DataAnnotations;

namespace HoE.CoreBusiness
{
    public class TeacherViewModel
    {
        [Key]
        public int T_ID { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        

    }
}
