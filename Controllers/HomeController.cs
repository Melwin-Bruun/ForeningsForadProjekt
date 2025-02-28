using FöreningsFörådProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace FöreningsFörådProjekt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           

			using (DbConnect database = new DbConnect())
			{
				var news = database.NewsInfo.Include(d => d.Author).OrderByDescending(b => b.Id).Take(3).ToList();


				return View(news);
			}
			
		}
        public IActionResult About()
        {
            return View();
        }
    }
}
