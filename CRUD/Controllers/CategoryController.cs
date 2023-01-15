
using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext  db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categorulist = _db.Categories.ToList();     
            return View(categorulist);
        }

        //this is for create;
        //Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for update;
        public IActionResult Edit(int? id)
        {
            if ( id==null || id==0)
            {
                return NotFound();  
            }
            var category = _db.Categories.Find(id);  
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category obj)
        {
            _db.Categories.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
           var obj =  _db.Categories.Find(id);
            _db.Categories.Remove(obj);
            _db.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
