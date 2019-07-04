using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.DAL
{
    public class PaintingDataAccess
    {

        private readonly PaintingContext _context;
        public PaintingDataAccess(PaintingContext context)
        {
            _context = context;
        }

        public void InitDatabase()
        {
            if (_context.Paintings.Count() == 0)
            {
                _context.Paintings.Add(new Painting { title = "Superbe peinture", author = new Author { firstName = "Sushil", lastName = "Ghambir", id=1 }, AuthorId=1 });
                _context.SaveChanges();
            }
        }

        public List<Painting> GetPaintings()
        {
            return _context.Paintings.ToList();
        }
    }
}