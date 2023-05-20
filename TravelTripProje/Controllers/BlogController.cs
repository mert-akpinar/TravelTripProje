using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;
namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        BlogComment Bc = new BlogComment();
        Context c = new Context();
        public ActionResult Index()
        {
            Bc.Deger1 = c.Blogs.ToList();
            Bc.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(Bc);
        }
        public ActionResult BlogDetay(int id)
        {            
            Bc.Deger1 = c.Blogs.Where(x=>x.ID == id).ToList();
            Bc.Deger2 = c.Commentss.Where(x => x.BlogID == id).ToList();
            return View(Bc);
        }
        [HttpGet]
        public PartialViewResult ToComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ToComment(Blog b)
        { 
            c.Blogs.Add(b);
            c.SaveChanges();
            return PartialView();
        }
    }
}