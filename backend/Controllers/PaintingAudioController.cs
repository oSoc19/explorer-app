using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class PaintingAudioController : ControllerBase
    {
        private readonly PaintingAudioDataAcceses _paintingAudioDataAccess;
        private readonly IMapper _mapper;
        public PaintingAudioController(ExplorerContext context, IMapper mapper)
        {
            _paintingAudioDataAccess = new PaintingAudioDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/paintingAudio
        [HttpGet]
        [Route("api/paintingAudio")]
        public ActionResult<IEnumerable<PaintingAudio>> GetPaintingAudios()
        {
            var paintingAudios = _paintingAudioDataAccess.GetPaintingAudios();
            var paintingAudiosDto = _mapper.Map<List<PaintingAudioDto>>(paintingAudios);
            return Ok(paintingAudiosDto);
        }

        // GET: api/paintingAudio/{id}
        [HttpGet]
        [Route("api/paintingAudio/{id}")]
        public ActionResult<PaintingAudio> GetPainting(long id)
        {
            PaintingAudio paintingAudio = _paintingAudioDataAccess.GetPaintingAudio(id);
            if (paintingAudio == null){
                return NotFound();
            }
            PaintingAudioDto paintingAudioDto = _mapper.Map<PaintingAudioDto>(paintingAudio);
            return Ok(paintingAudioDto);
        }
    }
}
