using Microsoft.AspNetCore.Mvc;
using SatışÖrnek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Controllers
{
    public class KulupController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Kulup.ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kulup kulup)
        {
            x.Kulup.Add(kulup);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
           var kulup= x.Kulup.Find(id);
            x.Kulup.Remove(kulup);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KulupGetir(int id)
        {
            var kulup = x.Kulup.Find(id);
          
            return View("KulupGetir",kulup);
        }
        public IActionResult Guncelle(Kulup k)
        {
            var klp = x.Kulup.Find(k.KulupId);
            klp.KulupAd = k.KulupAd;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
