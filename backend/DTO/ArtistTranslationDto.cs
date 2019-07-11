using System;
using backend.Models;

namespace backend.dto
{
    public class ArtistTranslationDto
    {
        public long Id {get;set;}
        public long ArtistId {get;set;}
        public long LanguageId {get;set;}
        public String Description {get;set;}

        public ArtistDto Artist {get;set;}
        public virtual LanguageDto Language {get;set;}

    }
}