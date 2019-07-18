using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class PaintingStory
    {
        public long Id { get; set; }
        public String Title {get;set;}
        public String Text { get; set; }
        public String Subtitle {get;set;}
        public String ImageUrl {get;set;}
        public long LanguageId {get;set;}
        public long PaintingId { get; set;}
        [ForeignKey("PaintingId")]
        public virtual Painting Painting {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
    }
}

