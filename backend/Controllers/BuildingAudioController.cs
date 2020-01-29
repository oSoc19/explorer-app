using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class BuildingAudioController : ControllerBase
    {
        private readonly BuildingAudioDataAcceses _buildingAudioDataAccess;
        private readonly IMapper _mapper;
        public BuildingAudioController(ExplorerContext context, IMapper mapper)
        {
            _buildingAudioDataAccess = new BuildingAudioDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/buildingAudio
        [HttpGet]
        [Route("api/buildingAudio")]
        public ActionResult<IEnumerable<BuildingAudio>> GetBuildingAudios()
        {
            var buildingAudios = _buildingAudioDataAccess.GetBuildingAudios();
            var buildingAudiosDto = _mapper.Map<List<BuildingAudioDto>>(buildingAudios);
            return Ok(buildingAudiosDto);
        }

        // GET: api/buildingAudio/{id}
        [HttpGet]
        [Route("api/buildingAudio/{id}")]
        public ActionResult<BuildingAudio> GetBuilding(long id)
        {
            BuildingAudio buildingAudio = _buildingAudioDataAccess.GetBuildingAudio(id);
            if (buildingAudio == null){
                return NotFound();
            }
            BuildingAudioDto buildingAudioDto = _mapper.Map<BuildingAudioDto>(buildingAudio);
            return Ok(buildingAudioDto);
        }

        [HttpPost]
        [Route("api/buildingAudio/{id}")]
        public IActionResult PostAudioGuide(long id,string languageCode)
        {

            return Ok();
        }
    }
}
