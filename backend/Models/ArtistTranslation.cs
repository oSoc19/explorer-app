using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class ArtistTranslation
    {
        public long Id {get;set;}
        public long ArtistId {get;set;}
        public long LanguageId {get;set;}
        public String Description {get;set;}

        [ForeignKey("ArtistId")]
        public virtual Artist Artist {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}

        public String SourceLink {get;set;}

    }
}