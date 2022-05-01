using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CIDM3312_Final.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HuntersHunt>().HasKey(s => new {s.HunterID, s.HuntID});
        }

        public DbSet<Hunt> Hunts {get; set;}
        public DbSet<Hunter> Hunters {get; set;}
        public DbSet<HuntersHunt> HuntersHunts {get; set;}
    }
}