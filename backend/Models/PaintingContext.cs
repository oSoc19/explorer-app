using Microsoft.EntityFrameworkCore;
namespace backend.Models
{
    public class PaintingContext : DbContext
    {
        public PaintingContext(DbContextOptions<PaintingContext> options) : base(options)
        {
        }

        public DbSet<Painting> Paintings { get; set; }
    }
}
