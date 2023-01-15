using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SupplierController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Suppliers = _db.Suppliers.ToList();
            return View(Suppliers);
        }

        //this is for create 

        public ActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            _db.Suppliers.Add(supplier);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for the update 
        public ActionResult Edit(int? id)
        {
            var obj = _db.Suppliers.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            _db.Suppliers.Update(supplier);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //this is for the delete
        public ActionResult Delete(int? id)
        {
            var obj = _db.Suppliers.Find(id);
            _db.Suppliers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
