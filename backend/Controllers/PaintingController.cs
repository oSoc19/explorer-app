using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaintingController : ControllerBase
    {
        private readonly PaintingContext _context;

        public PaintingController(PaintingContext context)
        {
            _context = context;

            if (_context.Paintings.Count() == 0)
            {
                _context.Paintings.Add(new Painting { title = "Superbe peinture", author = new Author { firstName = "Sushil", lastName = "Ghambir" } });
                _context.SaveChanges();
            }
        }

        // GET: api/Painting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Painting>>> GetPaintings()
        {
            return await _context.Paintings.ToListAsync();
        }

        // GET: api/paintings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Painting>> GetPainting(long id)
        {
            var painting = await _context.Paintings.FindAsync(id);

            if (painting == null)
            {
                return NotFound();
            }

            return painting;
        }
    }
}