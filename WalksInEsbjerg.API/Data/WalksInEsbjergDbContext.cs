using Microsoft.EntityFrameworkCore;
using WalksInEsbjerg.API.Models.Domain;

namespace WalksInEsbjerg.API.Data
{
    public class WalksInEsbjergDbContext: DbContext
    {
        public WalksInEsbjergDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
