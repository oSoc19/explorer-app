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
        public DateTime birthDate { get; set; }
        public DateTime deathDate { get; set; }
        public virtual List<ArtistTranslationDto> Translations {get;set;}

    }
}

