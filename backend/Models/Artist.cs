using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Artist
    {
        public long id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String nationality { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime deathDate { get; set; }
        public String description { get; set; }

        public List<Painting> paintings {get;set;}

    }
}

