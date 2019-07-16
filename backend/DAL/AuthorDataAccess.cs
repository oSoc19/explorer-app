using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class ArtistDataAccess
    {
        private readonly ExplorerContext _context;

        public ArtistDataAccess(ExplorerContext context){
            _context = context;
        }

        public List<Artist> GetArtists(){
            return _context.Artist.ToList();
        }

        public Artist GetArtist(long id){
            return _context.Artist.Find(id);
        }
    }
}
