using System;
namespace backend.Models
{
    public class Painting
    {
        public long id { get; set; }
        public String title { get; set; }
        public Author author { get; set; }
        public String imageUrl { get; set; }
        public String year { get; set; }
    }
}
