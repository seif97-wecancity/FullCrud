using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
   
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var employees = _db.Employees.ToList();
            return View(employees);
        }


        //this is for create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee obj)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for update 
        public ActionResult Edit(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Employees.Find(id);
            return View(obj);
        }
        [HttpPost] 
        public ActionResult Edit(Employee obj)
        {
            
            _db.Employees.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for delete
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Employees.Find(id);
            _db.Employees.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
