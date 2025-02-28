using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FöreningsFörådProjekt.Models
{
	public class Anvandare
	{
		public int Id { get; set; } //Definierar primary key, auto-increment
		public string AnvandareNamn { get; set; }
		public string Losernord { get; set; }

        public List<ReservationSchedule> Reservations { get; set; }



    }
}
