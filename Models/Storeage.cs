using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FöreningsFörådProjekt.Models
{
	public class Storeage
	{
		public int Id { get; set; } //Definierar primary key, auto-increment
		public string ItemName { get; set; }
		public int Amount { get; set; }

		public bool booked { get; set; }
		

        public List<ReservationSchedule> Reservations { get; set; }

    }
}
