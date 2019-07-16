using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly ArtistDataAccess _artistDataAccess;
        private readonly IMapper _mapper;
        public ArtistController(ExplorerContext context, IMapper mapper)
        {
            _artistDataAccess = new ArtistDataAccess(context);
            _mapper = mapper;
        }

        // GET: api/artist
        [HttpGet]
        [Route("api/artist")]
        public ActionResult<IEnumerable<Artist>> GetArtists()
        {
            var artists = _artistDataAccess.GetArtists();
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);
            return Ok(artistsDto);
        }

        // GET: api/artist/{id}
        [HttpGet]
        [Route("api/artist/{id}")]
        public ActionResult<Artist> GetPainting(long id)
        {
            Artist artist = _artistDataAccess.GetArtist(id);
            if (artist == null){
                return NotFound();
            }
            ArtistDto artistDto = _mapper.Map<ArtistDto>(artist);
            return Ok(artistDto);
        }
    }
}
