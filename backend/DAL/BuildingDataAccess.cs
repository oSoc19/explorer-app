using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class BuildingDataAccess
    {

        private readonly ExplorerContext _context;
        public BuildingDataAccess(ExplorerContext context)
        {
            _context = context;
        }

        public void InitDatabase(){
            var rand = _context.Building.Count();
            _context.Building.Add(new Building { 
                    Author = new Artist{FirstName = "Sushil"+rand, LastName = "Ghambir"+rand},
                    Use = new Use{}});
            _context.SaveChanges();
        }

        public Building GetBuildingByMuseumNumber(string number)
        {
            return _context.Building.Where(p => p.MuseumCode.Equals(number)).FirstOrDefault();
        }

        public List<Building> GetBuildings(){
            return _context.Building.ToList();
        }

        public Building GetBuilding(long id){
            return _context.Building.Find(id);
        }
    }
}