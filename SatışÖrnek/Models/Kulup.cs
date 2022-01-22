using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Models
{
    public class Kulup
    {
        [Key]
        public int KulupId { get; set; }
        public string KulupAd { get; set; }
        public string KulupKontejan { get; set; }


        public List<Ogrenci> Ogrencı { get; set; }

    }
}
