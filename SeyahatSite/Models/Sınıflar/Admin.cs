using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatSite.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Kullanıcı { get; set; }
        public string Sifre { get; set; }

    }
}