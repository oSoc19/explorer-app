using System;
namespace backend.Models
{
    public class PaintingAudio
    {
        public long id { get; set; }
        public String name { get; set; }
        public String audioUrl {get;set;}
        public String language{get;set;}
        public long paintingId { get; set;}
        public virtual Painting painting {get;set;}
    }
}

