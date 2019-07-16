using System;
namespace backend.dto
{
    public class PaintingAudioDto
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String AurioUrl {get;set;}
        public LanguageDto Language{get;set;}
    }
}

