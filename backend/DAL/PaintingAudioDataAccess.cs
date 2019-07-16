using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class PaintingAudioDataAcceses
    {

        private readonly ExplorerContext _context;
        public PaintingAudioDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<PaintingAudio> GetPaintingAudios(){
            return _context.PaintingAudio.ToList();
        }

        public PaintingAudio GetPaintingAudio(long id){
            return _context.PaintingAudio.Find(id);
        }
    }
}
