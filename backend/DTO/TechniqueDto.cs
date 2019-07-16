using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.dto
{
    public class TechniqueDto
    {
        public long Id { get; set; }
        public virtual List<TechniqueTranslationDto> Translations {get;set;}

        public void FilterByLanguage(string language){
            this.Translations = this.Translations.Where(tt => tt.Language.Code == language).ToList();
        }
    }
}

