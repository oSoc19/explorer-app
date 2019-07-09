using System;
using System.Collections.Generic;
using backend.Models;

namespace backend.Models
{
    public class Technique
    {
        public long id { get; set; }
        public String name { get; set; }
        public String description { get; set; }

        public virtual List<Artist> artists {get;set;}
    }
}

