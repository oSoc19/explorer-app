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

        // GET: api/painting
        [HttpGet]
        [Route("api/painting")]
        public ActionResult<IEnumerable<Painting>> GetPaintings()
        {
            return Ok(_paintingDataAccess.GetPaintings());
        }

        // GET: api/painting/{id}
        [HttpGet]
        [Route("api/painting/{id}")]
        public ActionResult<Painting> GetPainting(long id)
        {
            var painting = _paintingDataAccess.GetPainting(id);

            if (painting == null)
            {
                return NotFound();
            }

            return Ok(painting);
        }
    }
}