using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.dto
{
    public class BuildingDto
    {
        public long Id { get; set; }
        public int Year { get; set; }
        public virtual UseDto Use {get;set;}
        public virtual MovementDto Movement {get;set;}
        public virtual List<BuildingTranslationDto> Translations {get;set;}
        public virtual List<BuildingStoryDto> Stories {get;set;}

        public void FilterByLanguage(string language){
            language = language.ToUpper();
            Use.FilterByLanguage(language);
            Movement.FilterByLanguage(language);
            this.Stories = this.Stories.Where(s => s.Language.Code == language).ToList();
            this.Translations = this.Translations.Where(pt => pt.Language.Code == language).ToList();
        }
    }
}
