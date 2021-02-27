using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SeyahatSite.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public DateTime Tarih { get; set; }
        public string Acıklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> yorumlars { get; set; }
    }
}