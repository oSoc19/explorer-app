using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.dto
{
    public class ArtistDto
    {
        public long Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nationality { get; set; }
        public String BirthDate { get; set; }
        public String DeathDate { get; set; }
        public virtual List<ArtistTranslationDto> Translations {get;set;}

        public void FilterByLanguage(string language){
            this.Translations = this.Translations.Where(at => at.Language.Code == language).ToList();
        }

    }

}

