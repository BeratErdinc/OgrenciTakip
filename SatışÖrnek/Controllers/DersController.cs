using Microsoft.AspNetCore.Mvc;
using SatışÖrnek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Controllers
{
    public class DersController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Ders.ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Ders s)
        {
            x.Ders.Add(s);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int ıd)
        {
            var ders = x.Ders.Find(ıd);
            x.Ders.Remove(ders);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Getir(int id)
        {
            var ders = x.Ders.Find(id);

            return View("Getir",ders);
        }
        public IActionResult Guncelle(Ders dr)
        {
            var ders = x.Ders.Find(dr.DersId);
            ders.DersAdı = dr.DersAdı;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
