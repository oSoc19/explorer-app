using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class UseTranslation
    {
        public long Id {get;set;}
        public long UseId {get;set;}
        public String Name {get;set;}
        public String Description {get;set;}
        public long LanguageId {get;set;}

        [ForeignKey("UseId")]
        public virtual Use Use {get;set;}
        [ForeignKey("LanguageId")]
        public virtual Language Language {get;set;}

        public String SourceLink {get;set;}
    }
}