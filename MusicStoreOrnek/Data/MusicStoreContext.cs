using Microsoft.EntityFrameworkCore;
using MusicStoreOrnek.Models;

namespace MusicStoreOrnek.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions options):base(options) 
        {
            
        }

        //sql tarafındaki tablolara karşılık gelecektir.
        //public DbSet<ClassAdi> TabloAdi { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
