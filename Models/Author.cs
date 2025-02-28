using Microsoft.AspNetCore.Mvc;

namespace FöreningsFörådProjekt.Models
{
    public class Author
    {
        public int Id { get; set; } //Definierar primary key, auto-increment
        public string AuthorNamn { get; set; }

        public List<News> News { get; set; }



    }
}
