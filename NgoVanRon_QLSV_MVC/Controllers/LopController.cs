using Microsoft.AspNetCore.Mvc;
using NgoVanRon_QLSV_MVC.Data;
using NgoVanRon_QLSV_MVC.Models;
using System.Collections.Generic;

namespace NgoVanRon_QLSV_MVC.Controllers
{
    public class LopController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<NgoVanRon_Lop> lop = _db.ngovanron_lop;
            return View(lop);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var b = _db.ngovanron_lop.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }
        public IActionResult Create()
        {
            return View();
        }
        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NgoVanRon_Lop obj)
        {
            if (ModelState.IsValid)
            {
                _db.ngovanron_lop.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(obj);

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var b = _db.ngovanron_lop.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }
        [HttpPost]
        public IActionResult Edit(NgoVanRon_Lop obj)
        {
            if (ModelState.IsValid)
            {
                _db.ngovanron_lop.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var b = _db.ngovanron_lop.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }

        [HttpPost]
        public IActionResult Delete_ron(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var b = _db.ngovanron_lop.Find(id);
            if (b == null) return NotFound();

            _db.ngovanron_lop.Remove(b);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
