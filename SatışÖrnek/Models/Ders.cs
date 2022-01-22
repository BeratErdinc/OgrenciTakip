using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Models
{
    public class Ders
    {
        [Key]
        public int DersId{ get; set; }
        public string DersAdı{ get; set; }

        public List<Notlar> Notlar { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }

    }
}
