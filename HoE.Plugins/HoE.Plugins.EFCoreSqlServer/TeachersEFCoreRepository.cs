using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoE.CoreBusiness;
using HoE.Plugins.InMemory;
using HoE.UseCase.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HoE.Plugins.EFCoreSqlServer
{
    public class TeachersEFCoreRepository: ITeachersRepository
    {
        private readonly IDbContextFactory<HoEContext> contextFactory;
        public TeachersEFCoreRepository(IDbContextFactory<HoEContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public Task AddTeacherAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Teacher>> GetTeachersByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Teachers.Where(x => x.Name.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();
        }

        public Task ViewTeachersByNameAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
