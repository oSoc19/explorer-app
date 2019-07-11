using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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

        public List<Painting> GetPaintings(){
            return _context.Painting
                .Include(painting => painting.Author)
                .Include(painting => painting.Movement)
                .Include(painting => painting.Technique)
                .ToList();
        }

        public Painting GetPainting(long id){
            return GetPaintings().Find(painting => painting.Id == id);
        }
    }
}