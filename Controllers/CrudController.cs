using FöreningsFörådProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace FöreningsFörådProjekt.Controllers
{
	public class CrudController : Controller
    {

        public IActionResult Index()
        {
			using (DbConnect database = new DbConnect())
			{
				var news = database.NewsInfo.Include(d => d.Author).ToList();
                 

				return View(news);
			}
		}

        public IActionResult NewsAdd()
        {
			using (DbConnect database = new DbConnect())
			{
				ViewBag.Author = database.AuthorInfo.ToList();


				return View();
			}
		}

        public IActionResult NewsDelete(int id)
        {
            using (DbConnect database = new DbConnect())
            {
                var news = database.NewsInfo.Find(id);
                return View(news);
            }
        }
    
        public IActionResult NewsUpdate()
        {
            using (DbConnect database = new DbConnect())
            {
                ViewBag.Author = database.AuthorInfo.ToList();
                return View();
            }
        }



        public IActionResult StorageIndex()
        {
            using (DbConnect database = new DbConnect())
            {
                var item = database.StorageContent.ToList();


                return View(item);
            }
        }

        public IActionResult StorageAdd()
        {
                return View();
        }

        public IActionResult StorageDelete(int id)
        {
            using (DbConnect database = new DbConnect())
            {
                var news = database.StorageContent.Find(id);
                return View(news);
            }
        }

        public IActionResult StorageUpdate(int id)
        {
            using (DbConnect database = new DbConnect())
            {
                ViewBag.Item = database.StorageContent.Find(id);
                return View();
            }
        }




        [HttpPost]
        public IActionResult NewsAdd(News nyNews)
        {
            using (DbConnect database = new DbConnect())
            {
                database.NewsInfo.Add(nyNews);
                database.SaveChanges();
            }
            //Gå till sidan som så man kan loga in
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult NewsDelete(News raderaNews)
        {
            using (DbConnect database = new DbConnect())
            {
                database.Remove(raderaNews);
                database.SaveChanges();
            }
            //Gå till sidan som visar listan över filmer
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult NewsUpdate(News ändradNews)
        {
            using (DbConnect database = new DbConnect())
            {
                database.Update(ändradNews);
                database.SaveChanges();
            }
            //Gå till sidan som visar listan över kurser
            return RedirectToAction("Index");
        }



		[HttpPost]
		public IActionResult StorageAdd(Storeage NyStoreage)
		{
			using (DbConnect database = new DbConnect())
			{
				database.StorageContent.Add(NyStoreage);
				database.SaveChanges();
			}
			//Gå till sidan som så man kan loga in
			return RedirectToAction("StorageIndex");
		}

		[HttpPost]
		public IActionResult StorageDelete(Storeage raderaStorage)
		{
			using (DbConnect database = new DbConnect())
			{
				database.Remove(raderaStorage);
				database.SaveChanges();
			}
			//Gå till sidan som visar listan över filmer
			return RedirectToAction("StorageIndex");
		}

		[HttpPost]
		public IActionResult StorageUpdate(Storeage andradStorage)
		{
			using (DbConnect database = new DbConnect())
			{
				database.Update(andradStorage);
				database.SaveChanges();
			}
			//Gå till sidan som visar listan över kurser
			return RedirectToAction("StorageIndex");
		}




	}

}
