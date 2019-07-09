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

        private readonly PaintingContext _context;
        public PaintingDataAccess(PaintingContext context)
        {
            _context = context;
        }

        public void InitDatabase(){
            var rand = _context.Paintings.Count();
            _context.Paintings.Add(new Painting { title = "Superbe peinture"+rand, 
                    author = new Artist{firstName = "Sushil"+rand, lastName = "Ghambir"+rand},
                    movement = new Movement{name = "Baroque"+rand},
                    technique = new Technique{name = "Oil painting"+rand}});
            _context.SaveChanges();
        }

        public List<Painting> GetPaintings(){
            return _context.Paintings
                .Include(painting => painting.author)
                .Include(painting => painting.movement)
                .Include(painting => painting.technique)
                .ToList();
        }

        public Painting GetPainting(long id){
            return GetPaintings().Find(painting => painting.id == id);
        }
    }
}