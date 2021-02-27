using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatSite.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog blog { get; set; }

    }
}