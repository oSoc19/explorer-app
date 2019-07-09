using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Painting
    {
        public long id { get; set; }

        //json string with different languages
        public String title { get; set; }
        public String description { get; set; }
        public long authorId {get;set;}

        [ForeignKey("authorId")]
        public virtual Artist author { get; set; }
        public String imageUrl { get; set; }
        public int year { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public long movementId {get;set;}

        [ForeignKey("movementId")]
        public virtual Movement movement {get;set;}
        public long techniqueId {get;set;}

        [ForeignKey("techniqueId")]
        public virtual Technique technique {get;set;}


    }
}
