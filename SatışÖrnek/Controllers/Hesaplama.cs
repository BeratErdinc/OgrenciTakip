using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Controllers
{
    public class Hesaplama : Controller
    {
        public IActionResult Index(double sayı1=0 , double sayı2=0, double sayı3=0, double proje=0)
        {
            var sonuc = (sayı1 + sayı2+sayı3+proje)/4;
            ViewBag.snc = sonuc;
            return View();
        }
    }
}
