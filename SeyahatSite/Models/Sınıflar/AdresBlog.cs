using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatSite.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int Id { get; set; }
        public int Başlık { get; set; }
        public string Açıklama { get; set; }
        public string AAdres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }

    }
}