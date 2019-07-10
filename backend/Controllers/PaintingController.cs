using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class PaintingController : ControllerBase
    {
        private readonly PaintingDataAccess _paintingDataAccess;
        private readonly IMapper _mapper;
        public PaintingController(PaintingContext context)
        {

            _paintingDataAccess = new PaintingDataAccess(context);
            _paintingDataAccess.InitDatabase();
            
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Painting, PaintingDto>();
                cfg.CreateMap<Artist, ArtistDto>();
                cfg.CreateMap<Movement, MovementDto>();
                cfg.CreateMap<PaintingAudio, PaintingAudioDto>();
                cfg.CreateMap<PaintingStory, PaintingStoryDto>();
                cfg.CreateMap<Technique, TechniqueDto>();
            });

            configuration.AssertConfigurationIsValid();
            _mapper = configuration.CreateMapper();
        }

        // GET: api/painting
        [HttpGet]
        [Route("api/painting")]
        public ActionResult<IEnumerable<Painting>> GetPaintings()
        {
            var paintings = _paintingDataAccess.GetPaintings();
            var paintingsDto = _mapper.Map<List<PaintingDto>>(paintings);
            return Ok(paintingsDto);
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
            var paintingDto = _mapper.Map<PaintingDto>(painting);
            return Ok(paintingDto);
        }
    }
}