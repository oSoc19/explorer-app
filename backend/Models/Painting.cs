using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace backend.Models
{
    public class Painting
    {
        public long Id { get; set; }
        //json string with different languages
        public long AuthorId {get;set;}

        [ForeignKey("AuthorId")]
        public virtual Artist Author { get; set; }
        public String ImageUrl { get; set; }
        public int Year { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public long MovementId {get;set;}

        [ForeignKey("MovementId")]
        public virtual Movement Movement {get;set;}
        public long TechniqueId {get;set;}
        [ForeignKey("TechniqueId")]
        public virtual Technique Technique {get;set;}
        public virtual List<PaintingAudio> Audios {get;set;}
        public virtual List<PaintingStory> Stories {get;set;}
        public virtual List<PaintingTranslation> Translations {get;set;}
    }
}
