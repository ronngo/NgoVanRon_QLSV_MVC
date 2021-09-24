using Microsoft.AspNetCore.Mvc;
using NgoVanRon_QLSV_MVC.Data;
using NgoVanRon_QLSV_MVC.Models;
using System.Collections.Generic;

namespace NgoVanRon_QLSV_MVC.Controllers
{
    public class SinhvienController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SinhvienController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<NgoVanRon_Sinhvien> sinhvien = _db.ngovanron_sinhvien;
            return View(sinhvien);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var b = _db.ngovanron_sinhvien.Find(id);
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
        public IActionResult Create(NgoVanRon_Sinhvien obj)
        {
            if (ModelState.IsValid)
            {
                _db.ngovanron_sinhvien.Add(obj);
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
            var b = _db.ngovanron_sinhvien.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }
        [HttpPost]
        public IActionResult Edit(NgoVanRon_Sinhvien obj)
        {
            if (ModelState.IsValid)
            {
                _db.ngovanron_sinhvien.Update(obj);
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

            var b = _db.ngovanron_sinhvien.Find(id);
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

            var b = _db.ngovanron_sinhvien.Find(id);
            if (b == null) return NotFound();

            _db.ngovanron_sinhvien.Remove(b);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
