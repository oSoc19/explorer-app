using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class BuildingAudio
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String AudioUrl {get;set;}
        public long LanguageId {get;set;}
        public long BuildingId { get; set;}
        [ForeignKey("BuildingId")]
        public virtual Building Building {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
    }
}

