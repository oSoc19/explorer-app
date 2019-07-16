using System;

namespace backend.dto
{
    public class LanguageDto
    {
        public long Id {get;set;}
        public String Name {get;set;}
        // Ex : FR / EN / NL / ...
        public String Code {get;set;}
    }
}