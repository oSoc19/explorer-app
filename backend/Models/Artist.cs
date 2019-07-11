using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Artist
    {
        public long Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nationality { get; set; }
        public String Birthdate { get; set; }
        public String Deathdate { get; set; }
        public virtual List<Painting> paintings {get;set;}
        public virtual List<ArtistTranslation> Translations {get;set;}

    }
}

