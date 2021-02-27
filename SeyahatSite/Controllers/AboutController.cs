using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSite.Models.Sınıflar;

namespace SeyahatSite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.hakkımızdas.ToList();
            return View(degerler);
        }
    }
}