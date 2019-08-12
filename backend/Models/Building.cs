using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace backend.Models
{
    public class Building
    {
        public long Id { get; set; }
        public int Year { get; set; }
        public long UseId {get;set;}
        public long MovementId {get;set;}

        public String MuseumCode {get;set;}

        [ForeignKey("UseId")]
        public virtual Use Use {get;set;}
        [ForeignKey("MovementId")]
        public virtual Movement Movement {get;set;}

        public virtual List<BuildingStory> Stories {get;set;}
        public virtual List<BuildingTranslation> Translations {get;set;}
    }
}
