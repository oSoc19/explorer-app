using System;

namespace backend.dto
{
    public class TechniqueTranslationDto
    {
        public long Id {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public virtual LanguageDto Language {get;set;}

        public String SourceLink {get;set;}
    }
}