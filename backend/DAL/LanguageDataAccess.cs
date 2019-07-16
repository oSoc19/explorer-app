using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.DAL
{
    public class LanguageDataAcceses
    {

        private readonly ExplorerContext _context;
        public LanguageDataAcceses(ExplorerContext context)
        {
            _context = context;
        }

        public List<Language> GetLanguages(){
            return _context.Language.ToList();
        }

        public Language GetLanguage(long id){
            return _context.Language.Find(id);
        }
    }
}