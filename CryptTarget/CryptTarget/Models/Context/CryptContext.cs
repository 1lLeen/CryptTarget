using Microsoft.EntityFrameworkCore;

namespace CryptTarget.Models.Context
{
    public class CryptContext:DbContext
    {

        public DbSet<Crypt> Crypts { get; set; }
        public CryptContext() { }
        public CryptContext(DbContextOptions<CryptContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
