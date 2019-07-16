using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class PaintingAudio
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String AudioUrl {get;set;}
        public long LanguageId {get;set;}
        public long PaintingId { get; set;}
        [ForeignKey("PaintingId")]
        public virtual Painting Painting {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
    }
}

