using Microsoft.EntityFrameworkCore;

namespace Anac.TesteGestaoQualidade.Infrastructure.Contexts
{
    public class DatabaseContext : DbContext
    {
        private string connectionString;
        public DatabaseContext(string connString)
        {
            connectionString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
