using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class BuildingStoryController : ControllerBase
    {
        private readonly BuildingStoryDataAccess _buildingStoryDataAccess;
        private readonly IMapper _mapper;
        public BuildingStoryController(ExplorerContext context, IMapper mapper)
        {
            _buildingStoryDataAccess = new BuildingStoryDataAccess(context);
            _mapper = mapper;
        }

        // GET: api/buildingStory
        [HttpGet]
        [Route("api/buildingStory")]
        public ActionResult<IEnumerable<BuildingStory>> GetBuildingStories()
        {
            var buildingStories = _buildingStoryDataAccess.GetBuildingStories();
            var buildingStoriesDto = _mapper.Map<List<BuildingStoryDto>>(buildingStories);
            return Ok(buildingStoriesDto);
        }

        // GET: api/buildingStory/{id}
        [HttpGet]
        [Route("api/buildingStory/{id}")]
        public ActionResult<BuildingStory> GetBuildingStory(long id)
        {
            BuildingStory buildingStory = _buildingStoryDataAccess.GetBuildingStory(id);
            if (buildingStory == null){
                return NotFound();
            }
            BuildingStoryDto buildingStoryDto = _mapper.Map<BuildingStoryDto>(buildingStory);
            return Ok(buildingStoryDto);
        }

        [HttpGet]
        [Route("api/images/building-stories/{filename}")]
        public ActionResult GetBuildingStoryImage(string filename)
        {
            try{
                byte[] b = System.IO.File.ReadAllBytes("data/images/building-stories/" + filename);
                return File(b, "image/jpeg");
            }catch(Exception e){
                return NotFound(e);
            }
        }
    }
}
