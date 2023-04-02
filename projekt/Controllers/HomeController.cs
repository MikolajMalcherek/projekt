using Microsoft.AspNetCore.Mvc;
using projekt.Data;
using Microsoft.EntityFrameworkCore;
using projekt.Models;
using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;
using Microsoft.Identity.Client;

namespace projekt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public ActionResult wyszukajZawodnikow(string imie, string nazwisko)
        {
            
            using (var dbContext = new ApplicationDbContext())
            {
                var query = from zawodnik in dbContext.Zawodnicy
                            where zawodnik.imie_zawodnika == imie && zawodnik.nazwisko_zawodnika == nazwisko
                            select zawodnik;
                return View(query);
            }
        }


        /*
        public IActionResult Search(string firstName, string lastName)
        {
            var zawodnicy = _context.Zawodnicy
                .Where(z =>
                    (string.IsNullOrEmpty(firstName) || z.imie_zawodnika.Contains(firstName)) &&
                    (string.IsNullOrEmpty(lastName) || z.nazwisko_zawodnika.Contains(lastName)))
                .ToList();

            return View(zawodnicy);
        }
        */


    }
}
