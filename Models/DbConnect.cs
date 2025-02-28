using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FöreningsFörådProjekt.Models
{
	public class DbConnect : DbContext
	{
		public DbSet<Anvandare> UserProfile { get; set; }
		public DbSet<News> NewsInfo { get; set; }
		public DbSet<Storeage> StorageContent { get; set; }

		public DbSet<Author> AuthorInfo { get; set; }

		public DbSet<ReservationSchedule> ReservationSchedule { get; set; }


		public DbConnect()
		{
			Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite("DataSource = WebDB.db"); //Databasfilens namn
		}
	}
}
