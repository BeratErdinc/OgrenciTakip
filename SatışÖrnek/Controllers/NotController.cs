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
    public class NotController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Notlar.Include(x => x.Ogrenci).Include(x => x.Ders).ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            List<SelectListItem> degerler = (from i in x.Ders.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.DersAdı,
                                                 Value = i.DersId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;


            List<SelectListItem> degerler2 = (from i in x.Ogrencıs.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.OgrenciAd,
                                                 Value = i.OgrenciId.ToString()

                                             }).ToList();
            ViewBag.dgr2 = degerler2;


            return View();
            
        }
        [HttpPost]
        public IActionResult Ekle(Notlar not)
        {
        
            var klp = x.Ders.Where(x => x.DersId == not.Ders.DersId).FirstOrDefault();
            var klp2 = x.Ogrencıs.Where(x => x.OgrenciId == not.Ogrenci.OgrenciId).FirstOrDefault();
            not.Ders = klp;
            not.Ogrenci = klp2;
            x.Notlar.Add(not);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var not = x.Notlar.Find(id);
            x.Notlar.Remove(not);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Düzenle(int id)
        {
            var per = x.Notlar.Where(x => x.NotId == id).FirstOrDefault();
            
                   List<SelectListItem> degerler = (from i in x.Ders.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = i.DersAdı,
                                                        Value = i.DersId.ToString()

                                                    }).ToList();
            ViewBag.dgr = degerler;


            List<SelectListItem> degerler2 = (from i in x.Ogrencıs.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.OgrenciAd,
                                                  Value = i.OgrenciId.ToString()

                                              }).ToList();
            ViewBag.dgr2 = degerler2;
            return View(per);
        }
        [HttpPost]
        public IActionResult Düzenle(Notlar nt ,int sınav1,int sınav2,int sınav3,int proje,Islem model)
        {
            if (model.ıslem == "Hesaplama")
            {
                int ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
                ViewBag.ort = ortalama;
            }
            if (model.ıslem=="Düzenle")
            {

            }
            return View();
        }
    }
}
