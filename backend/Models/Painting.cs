using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Painting
    {
        public long id { get; set; }
        public String title { get; set; }

        public long AuthorId {get;set;}

        [ForeignKey("AuthorId")]
        public virtual Author author { get; set; }
        public String imageUrl { get; set; }
        public String year { get; set; }
    }
}
