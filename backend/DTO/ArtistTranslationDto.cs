using System;
using backend.Models;

namespace backend.dto
{
    public class ArtistTranslationDto
    {
        public long Id {get;set;}
        public String Description {get;set;}
        public virtual LanguageDto Language {get;set;}

    }
}