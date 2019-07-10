using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Painting
    {
        public long id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public long AuthorId {get;set;}

        [ForeignKey("AuthorId")]
        public virtual Author author { get; set; }
        public String imageUrl { get; set; }
        public int year { get; set; }
        public String place { get; set; }
        public float height { get; set; }
        public float width { get; set; }

        public virtual List<Category> categories { get; set; }

        public virtual List<Tag> tags { get; set; }
        public String owner { get; set; }
    }
}
