using FöreningsFörådProjekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FöreningsFörådProjekt.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Storage()
        {
            using (DbConnect database = new DbConnect())
            {
                var item = database.StorageContent.ToList();


                return View(item);
            }
        }
        public IActionResult Cafe()
        {
            return View();
        }
        public IActionResult Facilities()
        {
            return View();
        }
        public IActionResult NewBody()
        {
            return View();
        }
    }
}
