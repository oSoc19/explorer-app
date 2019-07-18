using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class TechniqueTranslation
    {
        public long Id {get;set;}
        public long TechniqueId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public long LanguageId {get;set;}

        [ForeignKey("TechniqueId")]
        public virtual Technique Technique {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}
        public String SourceLink {get;set;}
    }
}