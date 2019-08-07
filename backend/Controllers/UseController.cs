using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class UseController : ControllerBase
    {
        private readonly UseDataAcceses _useDataAccess;
        private readonly IMapper _mapper;
        public UseController(ExplorerContext context, IMapper mapper)
        {
            _useDataAccess = new UseDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/use
        [HttpGet]
        [Route("api/use")]
        public ActionResult<IEnumerable<Use>> GetUses()
        {
            var uses = _useDataAccess.GetUses();
            var usesDto = _mapper.Map<List<UseDto>>(uses);
            return Ok(usesDto);
        }

        // GET: api/use/{id}
        [HttpGet]
        [Route("api/use/{id}")]
        public ActionResult<Use> GetPainting(long id)
        {
            Use use = _useDataAccess.GetUse(id);
            if (use == null){
                return NotFound();
            }
            UseDto useDto = _mapper.Map<UseDto>(use);
            return Ok(useDto);
        }
    }
}
