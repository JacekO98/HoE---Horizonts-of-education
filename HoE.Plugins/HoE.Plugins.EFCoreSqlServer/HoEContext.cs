using HoE.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace HoE.Plugins.EFCoreSqlServer
{
    public class HoEContext : DbContext
    {
        public DbSet<Kalendar>? Kalendars { get; set; }

        public DbSet<Level>? Levels { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<SummaryTable>? SummaryTables { get; set; }

        public DbSet<TAvaliable>? TAvaliables { get; set; }

        public DbSet<Teacher>? Teachers { get; set; }

        public DbSet<TLevels>? TLevelss { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SummaryTable>()
                .HasKey(st => new { st.T_ID, st.L_ID, st.S_ID, st.K_ID });

            modelBuilder.Entity<SummaryTable>()
                .HasOne(st => st.Kalendar)
                .WithMany(k => k.)
        }




    }
}
