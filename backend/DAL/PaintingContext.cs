using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.DAL
{
    public class PaintingContext : DbContext
    {
        public PaintingContext(DbContextOptions<PaintingContext> options) : base(options)
        {
        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Artist> Artists {get;set;}
    }
}
