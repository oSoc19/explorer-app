using System;
using System.Collections.Generic;

namespace backend.dto
{
    public class TechniqueDto
    {
        public long id { get; set; }
        public virtual List<TechniqueTranslationDto> Translations {get;set;}
    }
}

