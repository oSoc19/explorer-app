using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Use
    {
        public long Id { get; set; }
        public virtual List<Building> Buildings {get;set;}
        public virtual List<UseTranslation> Translations {get;set;}
    }
}

