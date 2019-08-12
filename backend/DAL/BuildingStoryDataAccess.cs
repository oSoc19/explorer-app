using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class BuildingStoryDataAccess
    {

        private readonly ExplorerContext _context;
        public BuildingStoryDataAccess(ExplorerContext context)
        {
            _context = context;
        }

        public List<BuildingStory> GetBuildingStories(){
            return _context.BuildingStory.ToList();
        }

        public BuildingStory GetBuildingStory(long id){
            return _context.BuildingStory.Find(id);
        }
    }
}
