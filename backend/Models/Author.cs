using System;
namespace TestApi.Models
{
    public class Author
    {
        public long id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String nationality { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime deathDate { get; set; }

    }
}

