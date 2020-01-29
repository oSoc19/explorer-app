using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class BuildingAudioDataAcceses
    {

        private readonly ExplorerContext _context;
        public BuildingAudioDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<BuildingAudio> GetBuildingAudios(){
            return _context.BuildingAudio.ToList();
        }

        public BuildingAudio GetBuildingAudio(long id){
            return _context.BuildingAudio.Find(id);
        }
    }
}
