using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class PaintingStoryDataAccess
    {

        private readonly ExplorerContext _context;
        public PaintingStoryDataAccess(ExplorerContext context)
        {
            _context = context;
        }

        public List<PaintingStory> GetPaintingStories(){
            return _context.PaintingStory.ToList();
        }

        public PaintingStory GetPaintingStory(long id){
            return _context.PaintingStory.Find(id);
        }
    }
}
