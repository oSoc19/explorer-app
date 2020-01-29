using System;
namespace backend.dto
{
    public class BuildingAudioDto
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String AudioUrl {get;set;}
        public LanguageDto Language{get;set;}
    }
}

