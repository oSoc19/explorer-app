using System;

namespace backend.dto
{
    public class PaintingTranslationDto
    {
        public long Id {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public virtual LanguageDto Language {get;set;}

        public String SourceLink {get;set;}
    }
}