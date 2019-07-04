using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class PaintingController : ControllerBase
    {
        private readonly PaintingDataAccess _paintingDataAccess;
        public PaintingController(PaintingContext context)
        {
            _paintingDataAccess = new PaintingDataAccess(context);
            _paintingDataAccess.InitDatabase();
        }

        // GET: api/Painting
        [HttpGet]
        [Route("api/painting")]
        public ActionResult<IEnumerable<Painting>> GetPaintings()
        {
            return Ok(_paintingDataAccess.GetPaintings());
        }

        // GET: api/paintings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Painting>> GetPainting(long id)
        {
            return Ok();
            // var painting = await _context.Paintings.FindAsync(id);

            // if (painting == null)
            // {
            //     return NotFound();
            // }

            // return painting;
        }
    }
}