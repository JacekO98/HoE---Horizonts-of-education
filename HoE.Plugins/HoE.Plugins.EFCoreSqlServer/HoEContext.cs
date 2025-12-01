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

        public DbSet<TLevels>? TLevels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TAvaliable relations
            modelBuilder.Entity<TAvaliable>()
                .HasKey(ta => new { ta.T_ID , ta.K_ID });

            modelBuilder.Entity<TAvaliable>()
                .HasOne(ta => ta.Kalendar)
                .WithMany(k => k.TAvaliable)
                .HasForeignKey(ta => ta.K_ID);

            modelBuilder.Entity<TAvaliable>()
                .HasOne(ta => ta.Teacher)
                .WithMany(t => t.TAvaliable)
                .HasForeignKey(ta => ta.T_ID);

            // SummaryTable relations
            modelBuilder.Entity<SummaryTable>()
                .HasKey(st => new { st.T_ID , st.L_ID, st.S_ID, st.K_ID });

            modelBuilder.Entity<SummaryTable>()
                .HasOne(st => st.Teacher)
                .WithMany(t => t.SummaryTable)
                .HasForeignKey(st => st.T_ID);

            modelBuilder.Entity<SummaryTable>()
                .HasOne(st => st.Level)
                .WithMany(l => l.SummaryTable)
                .HasForeignKey(st => st.L_ID);

            modelBuilder.Entity<SummaryTable>()
                .HasOne(st => st.Student)
                .WithMany(s => s.SummaryTable)
                .HasForeignKey(st =>  st.S_ID);

            modelBuilder.Entity<SummaryTable>()
                .HasOne(st => st.Kalendar)
                .WithMany(k => k.SummaryTable)
                .HasForeignKey(st => st.K_ID);

            

            //Seeding data
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { T_ID = "T01", Name = "Katarzyna Sikora", Picture = "erg" },
                new Teacher { T_ID = "T02", Name = "Magdalena Sikora", Picture = "erg" }
            );

        }




    }
}
