using Microsoft.EntityFrameworkCore;

namespace CryptTarget.Models.Db
{
    public class CryptContext:DbContext
    {
        public CryptContext(DbContextOptions<CryptContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }

        public DbSet<Crypt> crypts;
    }
}
