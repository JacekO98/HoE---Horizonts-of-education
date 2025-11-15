using HoE.CoreBusiness;
using HoE.UseCase.PluginInterfaces;


namespace HoE.Plugins.InMemory
{
    public class TeachersRepository : ITeachersRepository
    {
        private List<Teacher> _teachers;
        public TeachersRepository()
        {
            _teachers = new List<Teacher>()
            {
                new Teacher {T_ID = "T01", Name = "Katarzyna", Lastname = "Sikora"},
                new Teacher {T_ID = "T02", Name = "Magdalena", Lastname = "Sikora"}
            };
        }

        public Task AddTeacherAsync(Teacher teacher)
        {
            _teachers.Add(teacher);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task ViewTeachersByNameAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
