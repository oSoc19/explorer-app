using System;
using System.Collections.Generic;
using System.Linq;

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

        public void FilterByLanguage(string language){
            Author.FilterByLanguage(language);
            Movement.FilterByLanguage(language);
            Technique.FilterByLanguage(language);
            this.Audios = this.Audios.Where(a => a.Language.Code == language).ToList();
            this.Stories = this.Stories.Where(s => s.Language.Code == language).ToList();
            this.Translations = this.Translations.Where(pt => pt.Language.Code == language).ToList();
        }
    }
}
