using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Use
    {
        public long Id { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        
        public virtual List<UseTranslation> Translations {get;set;}
    }
}

