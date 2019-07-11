using System;
using System.Collections.Generic;

namespace backend.dto
{
    public class ArtistDto
    {
        public long id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String nationality { get; set; }
        public String birthDate { get; set; }
        public String deathDate { get; set; }
        public virtual List<ArtistTranslationDto> Translations {get;set;}

    }
}

