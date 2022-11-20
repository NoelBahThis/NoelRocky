using Microsoft.AspNetCore.Mvc;
using NoelRocky.Data;
using System.Linq;

namespace NoelRocky.Controllers
{
    public class FavFoodController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FavFoodController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.FavFoodList = _db.FavFoods.ToList();
            ViewBag.PersonList = _db.Persons.ToList();
            return View();
        }
    }
}
