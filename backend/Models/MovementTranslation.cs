using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class MovementTranslation
    {
        public long Id {get;set;}
        public long MovementId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public long LanguageId {get;set;}

        [ForeignKey("MovementId")]
        public virtual Movement Movement {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
    }
}