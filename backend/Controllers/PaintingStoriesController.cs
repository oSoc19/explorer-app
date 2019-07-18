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
    public class PaintingStoryController : ControllerBase
    {
        private readonly PaintingStoryDataAccess _paintingStoryDataAccess;
        private readonly IMapper _mapper;
        public PaintingStoryController(ExplorerContext context, IMapper mapper)
        {
            _paintingStoryDataAccess = new PaintingStoryDataAccess(context);
            _mapper = mapper;
        }

        // GET: api/paintingStory
        [HttpGet]
        [Route("api/paintingStory")]
        public ActionResult<IEnumerable<PaintingStory>> GetPaintingStories()
        {
            var paintingStories = _paintingStoryDataAccess.GetPaintingStories();
            var paintingStoriesDto = _mapper.Map<List<PaintingStoryDto>>(paintingStories);
            return Ok(paintingStoriesDto);
        }

        // GET: api/paintingStory/{id}
        [HttpGet]
        [Route("api/paintingStory/{id}")]
        public ActionResult<PaintingStory> GetPaintingStory(long id)
        {
            PaintingStory paintingStory = _paintingStoryDataAccess.GetPaintingStory(id);
            if (paintingStory == null){
                return NotFound();
            }
            PaintingStoryDto paintingStoryDto = _mapper.Map<PaintingStoryDto>(paintingStory);
            return Ok(paintingStoryDto);
        }

        [HttpGet]
        [Route("api/images/painting-stories/{filename}")]
        public ActionResult GetPaintingStoryImage(string filename)
        {
            try{
                byte[] b = System.IO.File.ReadAllBytes("/data/images/painting-stories/" + filename);
                return File(b, "image/jpeg");
            }catch(Exception e){
                return NotFound(e);
            }
        }
    }
}
