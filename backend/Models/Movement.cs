using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Movement
    {
        public long Id { get; set; }
        public virtual List<Painting> Paintings {get;set;}
        public virtual List<MovementTranslation> Translations {get;set;}
    }
}

