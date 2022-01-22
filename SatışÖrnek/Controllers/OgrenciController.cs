using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SatışÖrnek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Controllers
{
    public class OgrenciController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {

            var degerler = x.Ogrencıs.Include(x => x.Kulup).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            List<SelectListItem> degerler = (from i in x.Kulup.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulupAd,
                                                 Value = i.KulupId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Ogrenci ogrenci)
        {
            var klp = x.Kulup.Where(x => x.KulupId == ogrenci.Kulup.KulupId).FirstOrDefault();
            ogrenci.Kulup = klp;

            x.Ogrencıs.Add(ogrenci);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var ogrencı = x.Ogrencıs.Find(id);
            x.Ogrencıs.Remove(ogrencı);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Düzenle(int id)
        {
            var per =x.Ogrencıs.Where(x => x.OgrenciId == id).FirstOrDefault();

            List<SelectListItem> degerler = (from i in x.Kulup.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulupAd,
                                                 Value = i.KulupId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;

            return View(per);   
        }
        [HttpPost]
        public IActionResult Düzenle(Ogrenci ogr)
        {
            var per = x.Ogrencıs.Where(x => x.OgrenciId == ogr.OgrenciId).FirstOrDefault();
            per.OgrenciAd = ogr.OgrenciAd;
            per.OgrenciSoyad = ogr.OgrenciSoyad;
            per.OgrencıCınsıyet = ogr.OgrencıCınsıyet;
                
            var klp = x.Kulup.Where(x => x.KulupId == ogr.Kulup.KulupId).FirstOrDefault();
            per.Kulup = klp;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
