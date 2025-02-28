using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FöreningsFörådProjekt.Models
{
	public class News
	{
		public int Id { get; set; } //Definierar primary key, auto-increment
		public string Titel { get; set; }
		public string Content { get; set; }

		public int AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
