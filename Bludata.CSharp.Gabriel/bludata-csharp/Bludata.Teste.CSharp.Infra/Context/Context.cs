using Microsoft.EntityFrameworkCore;

namespace Bludata.Teste.CSharp.Infra
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }
    }
}
