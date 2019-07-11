using System;

namespace backend.dto
{
    public class TechniqueTranslationDto
    {
        public long Id {get;set;}
        public long TechniqueId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public long LanguageId {get;set;}
        public virtual LanguageDto Language {get;set;}
    }
}