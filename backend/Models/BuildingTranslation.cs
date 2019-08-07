using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace backend.Models
{
    public class BuildingTranslation
    {
        public long Id {get;set;}
        public long BuildingId {get;set;}
        public long LanguageId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        [ForeignKey("BuildingId")]
        public virtual Building Building {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}

        public String SourceLink {get;set;}
    }
}