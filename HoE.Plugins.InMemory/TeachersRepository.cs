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
                
            };
        }

        public Task AddTeacherAsync(Teacher teacher)
        {
            _teachers.Add(teacher);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_teachers);
            return _teachers.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public Task ViewTeachersByNameAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
