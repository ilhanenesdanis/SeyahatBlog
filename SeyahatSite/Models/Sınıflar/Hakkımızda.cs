using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatSite.Models.Sınıflar
{
    public class Hakkımızda
    {
        [Key]
        public int Id { get; set; }
        public string ResimUrl { get; set; }
        public string Hakkımda { get; set; }

    }
}