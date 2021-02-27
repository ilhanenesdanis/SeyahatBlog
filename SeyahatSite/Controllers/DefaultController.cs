using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSite.Models.Sınıflar;

namespace SeyahatSite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.blogs.Take(5).ToList();
            return View(degerler);
        }
        //her sayfa için bir controller metodu
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial()
        {
            var degerler = c.blogs.OrderByDescending(x => x.ID).Take(2).ToList();

            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.blogs.OrderBy(x => x.ID).Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}