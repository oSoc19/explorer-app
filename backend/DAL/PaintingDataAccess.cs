using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class PaintingDataAccess
    {

        private readonly ExplorerContext _context;
        public PaintingDataAccess(ExplorerContext context)
        {
            _context = context;
        }

        public void InitDatabase(){
            var rand = _context.Painting.Count();
            _context.Painting.Add(new Painting { 
                    Author = new Artist{FirstName = "Sushil"+rand, LastName = "Ghambir"+rand},
                    Movement = new Movement{},
                    Technique = new Technique{}});
            _context.SaveChanges();
        }

        public Painting GetPaintingByMuseumNumber(long number)
        {
            return _context.Painting.Where(p => p.MuseumNumber == number).FirstOrDefault();
        }

        public List<Painting> GetPaintings(){
            return _context.Painting.ToList();
        }

        public Painting GetPainting(long id){
            return _context.Painting.Find(id);
        }
    }
}