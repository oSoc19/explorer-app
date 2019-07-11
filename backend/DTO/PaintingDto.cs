using System;
using System.Collections.Generic;

namespace backend.dto
{
    public class PaintingDto
    {
        public long id { get; set; }

        //json string with different languages
        public String title { get; set; }
        public String description { get; set; }
        public virtual ArtistDto author { get; set; }
        public String imageUrl { get; set; }
        public int year { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public virtual MovementDto movement {get;set;}
        public virtual TechniqueDto technique {get;set;}
        public virtual List<PaintingAudioDto> audios {get;set;}
        public virtual List<PaintingStoryDto> stories {get;set;}

    }
}
