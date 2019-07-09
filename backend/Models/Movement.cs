using System;
using backend.Models;
using System.Collections.Generic;

namespace backend.Models
{
    public class Movement
    {
        public long id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public virtual List<Artist> artists {get;set;}
    }
}

