using Microsoft.AspNetCore.Mvc;

namespace FöreningsFörådProjekt.Models
{
    public class ReservationSchedule
    {
        public int Id { get; set; } //Definierar primary key, auto-increment
        
        public int AnvandareID { get; set; }
        public Anvandare Anvandare { get; set; }
        public int StoreageID { get; set; }

        public Storeage Storeage { get; set; }

        public string DateTime {  get; set; }

    }
}
