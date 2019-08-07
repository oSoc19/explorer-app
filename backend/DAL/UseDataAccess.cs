using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class UseDataAcceses
    {

        private readonly ExplorerContext _context;
        public UseDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<Use> GetUses(){
            return _context.Use.ToList();
        }

        public Use GetUse(long id){
            return _context.Use.Find(id);
        }
    }
}
