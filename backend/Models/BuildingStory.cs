using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class BuildingStory
    {
        public long Id { get; set; }
        public String Title {get;set;}
        public String Text { get; set; }
        public String Type { get; set; }
        public String Subtitle {get;set;}
        public String ImageUrl {get;set;}
        public long LanguageId {get;set;}
        public long BuildingId { get; set;}
        [ForeignKey("BuildingId")]
        public virtual Building Building {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
    }
}

