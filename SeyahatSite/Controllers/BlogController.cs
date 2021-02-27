using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSite.Models.Sınıflar;

namespace SeyahatSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            // var blog = c.blogs.ToList();
            by.deger1 = c.blogs.ToList();
            by.deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return View(by);
        }
        
        //Blogun detaylarını getircek
        public ActionResult BlogDetay(int id)
        {

            // var blogbul = c.blogs.Where(x => x.ID == id).ToList();
            by.deger1 = c.blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            by.deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar b)
        {
            c.yorumlars.Add(b);
            c.SaveChanges();
            return PartialView();
        }
    }
}