using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var students = _db.Students.ToList();   
            return View(students);
        }
        //this is for create;
        //Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student obj)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for update
        public IActionResult Edit(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(Student obj)
        {
            _db.Students.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is delete
        public ActionResult Delete(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
