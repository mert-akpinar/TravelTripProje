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
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        public ActionResult BlogDetay(int id)
        {
            var values = c.Blogs.Where(x => x.ID == id ).ToList();
            return View(values);
        }
    }
}