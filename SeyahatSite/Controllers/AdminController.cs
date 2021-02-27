using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSite.Models.Sınıflar;

namespace SeyahatSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult YeniBlog(Blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var b = c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bl = c.blogs.Find(id);
            return View("BlogGetir", bl);
        }
        [Authorize]
        public ActionResult BlogGüncelle(Blog b)
        {
            var blg = c.blogs.Find(b.ID);
            blg.Baslık = b.Baslık;
            blg.Acıklama = b.Acıklama;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorum = c.yorumlars.ToList();
            return View(yorum);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var yr = c.yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        [Authorize]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.yorumlars.Find(y.Id);
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }



    }
}