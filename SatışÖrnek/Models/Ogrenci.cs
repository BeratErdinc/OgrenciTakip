using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrencıCınsıyet { get; set; }
        public string OgrenciKulup { get; set; }


        public List<Notlar> Notlar { get; set; }

        public Kulup Kulup { get; set; }
        public int KulupId { get; set; }

        public Ders Ders { get; set; }



    }
}
