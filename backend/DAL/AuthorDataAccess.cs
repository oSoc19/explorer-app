using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class AuthorDataAccess
    {
        private readonly ExplorerContext _context;
        public AuthorDataAccess(ExplorerContext context)
        {
            _context = context;
        }

        public List<Artist> GetAuthors()
        {
            return _context.Artist.ToList();
        }
    }
}