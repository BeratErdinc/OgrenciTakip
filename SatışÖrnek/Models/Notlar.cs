using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Models
{
    public class Notlar
    {
        [Key]
        public int NotId { get; set; }
    
        public string Sınav1 { get; set; }
        public string Sınav2 { get; set; }
        public string Sınav3 { get; set; }
        public string Proje { get; set; }
        public decimal Ortalama { get; set; }




        public Ders Ders { get; set; }
        public int DersId { get; set; }

        public Ogrenci Ogrenci { get; set; }
        public int OgrenciId { get; set; }

    }
}
