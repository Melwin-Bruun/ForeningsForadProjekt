using FöreningsFörådProjekt.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FöreningsFörådProjekt.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult LoginPage(string returnUrl = "")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        public IActionResult CreateAcountPage()
        {
            return View();
        }

        [Authorize]
        public IActionResult Storeage()
		{
			using (DbConnect database = new DbConnect())
			{
				var item = database.StorageContent.ToList();


				return View(item);
			}
		}


        [Authorize]
        public IActionResult Index()
        {

            using (DbConnect database = new DbConnect())
            {
				var news = database.NewsInfo.Include(d => d.Author).OrderByDescending(b => b.Id).Take(3).ToList();



				return View(news);
            }

        }


        [HttpPost]
        public IActionResult CreateAcountPage(Anvandare NyAnvandare)
        {
            using (DbConnect database = new DbConnect())
            {
                database.UserProfile.Add(NyAnvandare);
                database.SaveChanges();
            }
            //Gå till sidan som så man kan loga in
            return RedirectToAction("LoginPage");
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(Anvandare user, string returnUrl = "")
        {
            //Kontrollera användarnamn
            bool userOk = CheckUser(user);
            if (userOk == true)
            {
                // Allt stämmer, logga in användaren
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.AnvandareNamn));
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
                // Skicka användaren vidare till returnUrl om den finns annars till startsidan
                if (returnUrl != "")
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("Index", "Home");
            }
            ViewBag.ErrorMessage = "Inloggningen inte godkänd";
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        private bool CheckUser(Anvandare userInfo) {
            int count = 0;
            using (DbConnect database = new DbConnect())
            {
                var validUsers = database.UserProfile.Where(u => u.AnvandareNamn == userInfo.AnvandareNamn).Where(u => u.Losernord == userInfo.Losernord);
                count = validUsers.Count();
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<IActionResult> SignOutUser()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }




    }

}




