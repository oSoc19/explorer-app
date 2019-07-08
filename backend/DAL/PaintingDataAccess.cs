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

        public async void InitDatabase()
        {
            if (_context.Paintings.Count() == 0)
            {
                var authorInsert =  new Author { firstName = "Sushil", lastName = "Ghambir" };
                _context.Authors.Add(authorInsert);
                _context.Paintings.Add(new Painting { title = "Superbe peinture", author = authorInsert, AuthorId=1 });
                await _context.SaveChangesAsync();
            }
        }

        public List<Painting> GetPaintings()
        {
            return _context.Paintings.ToList();
        }
    }
}