using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;

namespace HoE.Plugins.InMemory
{
    public class StudentsRepository : IStudentsRepository
    {
        List<Student> _students;
        public StudentsRepository() {
            _students = new List<Student>()
            {
                new Student { S_ID = 1, Name = "Ignacy Głuszak"},
                new Student { S_ID = 2, Name = "Miłosz"},
                new Student {S_ID = 3, Name = "Agata"}
            };
        }

        public async Task<IEnumerable<Student>> GetStudentsByNameUseCase(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_students);
            return _students.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
