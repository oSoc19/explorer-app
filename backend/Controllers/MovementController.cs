using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class MovementController : ControllerBase
    {
        private readonly MovementDataAcceses _movementDataAccess;
        private readonly IMapper _mapper;
        public MovementController(ExplorerContext context, IMapper mapper)
        {
            _movementDataAccess = new MovementDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/movement
        [HttpGet]
        [Route("api/movement")]
        public ActionResult<IEnumerable<Movement>> GetMovements()
        {
            var movements = _movementDataAccess.GetMovements();
            var movementsDto = _mapper.Map<List<MovementDto>>(movements);
            return Ok(movementsDto);
        }

        // GET: api/movement/{id}
        [HttpGet]
        [Route("api/movement/{id}")]
        public ActionResult<Movement> GetPainting(long id)
        {
            Movement movement = _movementDataAccess.GetMovement(id);
            if (movement == null){
                return NotFound();
            }
            MovementDto movementDto = _mapper.Map<MovementDto>(movement);
            return Ok(movementDto);
        }
    }
}
