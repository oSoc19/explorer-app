using System;
using System.Collections.Generic;

namespace backend.dto
{
    public class PaintingDto
    {
        public long Id { get; set; }
        public virtual ArtistDto Author { get; set; }
        public String ImageUrl { get; set; }
        public int Year { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public virtual MovementDto Movement {get;set;}
        public virtual TechniqueDto Technique {get;set;}
        public virtual List<PaintingAudioDto> Audios {get;set;}
        public virtual List<PaintingStoryDto> Stories {get;set;}
        public virtual List<PaintingTranslationDto> Translations {get;set;}

    }
}
