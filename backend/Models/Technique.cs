using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Technique
    {
        public long Id { get; set; }
        public virtual List<TechniqueTranslation> Translations {get;set;}

    }
}

