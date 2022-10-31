using Microsoft.EntityFrameworkCore;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.ORM;

namespace Web_App.ORM
{
    public class ApplicationDbContext:DbContext,IApplicationDbContext
    {
        public readonly  string? _connnectionstring;
        public readonly  string? _assembly;
        public ApplicationDbContext(string? Connectionstring,string? Assembly)
        {
            _connnectionstring = Connectionstring;
            _assembly = Assembly;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connnectionstring,
                    e => e.MigrationsAssembly(_assembly));
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
