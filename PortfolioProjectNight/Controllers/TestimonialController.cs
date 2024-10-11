using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DbMyPortfolioNightEntities context=new DbMyPortfolioNightEntities();

        public ActionResult TestimonialIndex()
        {
            var values=context.Testimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = context.Testimonial.Find(id);
            context.Testimonial.Remove(values);
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = context.Testimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var values = context.Testimonial.Find(testimonial.TestimonialID);
            values.Title = testimonial.Title;
            values.Name = testimonial.Name;
            values.Comment = testimonial.Comment;
            values.ImageUrl = testimonial.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
    }
}