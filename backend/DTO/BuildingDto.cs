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

        public void FilterByLanguage(string language){
            language = language.ToUpper();
            Use.FilterByLanguage(language);
            Movement.FilterByLanguage(language);
            this.Translations = this.Translations.Where(pt => pt.Language.Code == language).ToList();
        }
    }
}
