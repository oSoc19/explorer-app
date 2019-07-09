using System;
using System.Collections.Generic;
using backend.Models;

namespace backend.Models
{
    public class PaintingFact
    {
        public long id { get; set; }
        public String text { get; set; }
        public String imageUrl {get;set;}
        public String language {get;set;}
        public long paintingId { get; set;}
        public virtual Painting painting {get;set;}
    }
}

