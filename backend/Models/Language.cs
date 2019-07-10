using System;

namespace backend.Models
{
    public class Language
    {
        public long Id {get;set;}
        public String Name {get;set;}
        // Ex : FR / EN / NL / ...
        public String Code {get;set;}
    }
}