using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace backend.Models
{
    public class PaintingTranslation
    {
        public long Id {get;set;}
        public long PaintingId {get;set;}
        public long LanguageId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        [ForeignKey("PaintingId")]
        public virtual Painting Painting {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}

        public String SourceLink {get;set;}
    }
}