using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.dto
{
    public class UseDto
    {
        public long Id { get; set; }
        public virtual List<UseTranslationDto> Translations {get;set;}

        public void FilterByLanguage(string language){
            this.Translations = this.Translations.Where(mt => mt.Language.Code == language).ToList();
        }
    }
}

