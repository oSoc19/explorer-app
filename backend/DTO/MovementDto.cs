using System;
using System.Collections.Generic;

namespace backend.dto
{
    public class MovementDto
    {
        public long id { get; set; }
        public virtual List<MovementTranslationDto> Translations {get;set;}
    }
}

