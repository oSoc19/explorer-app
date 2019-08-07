using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;
using System.Linq;

namespace backend.Controllers
{
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly BuildingDataAccess _buildingDataAccess;
        private readonly IMapper _mapper;
        public BuildingController(ExplorerContext context, IMapper mapper)
        {
            _buildingDataAccess = new BuildingDataAccess(context);
            _mapper = mapper;
        }

        // GET: api/building
        [HttpGet]
        [Route("api/building")]
        public ActionResult<IEnumerable<Building>> GetBuildings()
        {
            var buildings = _buildingDataAccess.GetBuildings();
            var buildingsDto = _mapper.Map<List<BuildingDto>>(buildings);
            return Ok(buildingsDto);
        }

        // GET: api/building/{id}
        [HttpGet]
        [Route("api/building/{id}")]
        public ActionResult<Building> GetBuilding(long id, string language)
        {
            Building building = _buildingDataAccess.GetBuilding(id);
            if (building == null){
                return NotFound();
            }
            BuildingDto buildingDto = _mapper.Map<BuildingDto>(building);
            
            return Ok(buildingDto);
        }

        [HttpGet]
        [Route("api/building/museum/{buildingNumber}")]
        public ActionResult<Building> GetBuildingByMuseumNumber(string buildingNumber, string language)
        {
            Building building = _buildingDataAccess.GetBuildingByMuseumNumber(buildingNumber);
            if (building == null){
                return NotFound();
            }
            BuildingDto buildingDto = _mapper.Map<BuildingDto>(building);
            
            return Ok(buildingDto);
        }
    }
}