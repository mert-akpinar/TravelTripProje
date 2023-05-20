﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;
namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FindBlog(int id)
        {
            var b1 = c.Blogs.Find(id);
            return View("FindBlog", b1);

        }
        public ActionResult UpdateBlog(Blog b)
        {
            var value = c.Blogs.Find(b.ID);
            value.Description = b.Description;
            value.Title = b.Title;
            value.BlogImageUrl = b.BlogImageUrl;
            value.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}