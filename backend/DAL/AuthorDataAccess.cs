using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class AuthorDataAccess
    {
        private readonly PaintingContext _context;
        public AuthorDataAccess(PaintingContext context)
        {
            _context = context;
        }

        public List<Artist> GetAuthors()
        {
            return _context.Artist.ToList();
        }
    }
}