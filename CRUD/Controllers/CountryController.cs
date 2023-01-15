using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CountryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var countries = _db.Countries.ToList();
            return View(countries);
        }

        //this is to create

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Country country)
        {
            _db.Countries.Add(country);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for the update

        public ActionResult Edit(int? id)
        {
            var obj = _db.Countries.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Country country)
        {
            _db.Countries.Update(country);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is the delete

        public ActionResult Delete(int id)
        {
            var obj = _db.Countries.Find(id);
            _db.Countries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
