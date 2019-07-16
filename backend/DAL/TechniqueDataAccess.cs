using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class TechniqueDataAcceses
    {

        private readonly ExplorerContext _context;
        public TechniqueDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<Technique> GetTechniques(){
            return _context.Technique.ToList();
        }

        public Technique GetTechnique(long id){
            return _context.Technique.Find(id);
        }
    }
}
