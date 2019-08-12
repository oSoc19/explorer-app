using System;

namespace backend.dto
{
    public class BuildingStoryDto
    {
        public long Id { get; set; }
        public String Title {get;set;}
        public String Type {get;set;}
        public String Subtitle {get;set;}
        public String Text { get; set; }
        public String ImageUrl {get;set;}
        public LanguageDto Language {get;set;}
    }
}

