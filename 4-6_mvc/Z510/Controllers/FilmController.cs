using Microsoft.AspNetCore.Mvc;
using Z510.Models;

namespace Z510.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var film = new FilmModel()
            {
               
                Title = "Orka",
                Year = 1974
            };

            var filmManager = new FilmManager();
            filmManager.AddFilm(film);

            return View();
        }
    }
}
