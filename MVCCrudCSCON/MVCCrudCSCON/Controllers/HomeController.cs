using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrudCSCON.Models;

namespace MVCCrudCSCON.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        CsConDB _db = new CsConDB();
        public ActionResult List()
        {
            var students = _db.Students.ToList();
            return View(students);
        }

        public ActionResult YeniOlustur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Student student)
        {
            Student yeni = new Student();
            yeni.Name = student.Name;
            yeni.Surname = student.Surname;
            yeni.Age = student.Age;

            _db.Students.Add(yeni);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Sil(int id)
        {
            Student silinecekStudent = _db.Students.Find(id);
            _db.Students.Remove(silinecekStudent);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Duzenle(int id)
        {
            Student duzenlenecekStudent = _db.Students.Find(id);
            return View(duzenlenecekStudent);
        }

        public ActionResult Guncelle(Student duzenlenen)
        {
            Student std = _db.Students.Find(duzenlenen.ID);
            std.Name = duzenlenen.Name;
            std.Surname = duzenlenen.Surname;
            std.Age = duzenlenen.Age;

            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}