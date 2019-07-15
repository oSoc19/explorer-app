using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class MovementDataAcceses
    {

        private readonly ExplorerContext _context;
        public MovementDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<Movement> GetMovements(){
            return _context.Movement.ToList();
        }

        public Movement GetMovement(long id){
            return _context.Movement.Find(id);
        }
    }
}
