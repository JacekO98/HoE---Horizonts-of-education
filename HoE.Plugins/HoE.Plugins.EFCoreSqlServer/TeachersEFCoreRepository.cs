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

        public async Task AddTeacherAsync(Teacher teacher)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.Teachers.Add(teacher);
            await db.SaveChangesAsync();
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
