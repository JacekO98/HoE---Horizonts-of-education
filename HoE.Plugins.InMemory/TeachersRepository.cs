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

        public Task DeleteTeacherAsync(Teacher teacher)
        {
            var index = _teachers.FindIndex(x => x.T_ID == teacher.T_ID);
            _teachers.RemoveAt(index);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_teachers);
            return _teachers.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Teacher> ViewTeachersByIdUseCase(int T_ID)
        {
            return await Task.FromResult(_teachers.First(x => x.T_ID == T_ID));
        }

        public Task ViewTeachersByNameAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
