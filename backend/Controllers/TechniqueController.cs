using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class TechniqueController : ControllerBase
    {
        private readonly TechniqueDataAcceses _techniqueDataAccess;
        private readonly IMapper _mapper;
        public TechniqueController(ExplorerContext context, IMapper mapper)
        {
            _techniqueDataAccess = new TechniqueDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/technique
        [HttpGet]
        [Route("api/technique")]
        public ActionResult<IEnumerable<Technique>> GetTechniques()
        {
            var techniques = _techniqueDataAccess.GetTechniques();
            var techniquesDto = _mapper.Map<List<TechniqueDto>>(techniques);
            return Ok(techniquesDto);
        }

        // GET: api/technique/{id}
        [HttpGet]
        [Route("api/technique/{id}")]
        public ActionResult<Artist> GetPainting(long id)
        {
            Technique technique = _techniqueDataAccess.GetTechnique(id);
            if (technique == null){
                return NotFound();
            }
            TechniqueDto techniqueDto = _mapper.Map<TechniqueDto>(technique);
            return Ok(techniqueDto);
        }
    }
}
