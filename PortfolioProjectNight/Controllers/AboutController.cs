using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult AboutIndex()
        {
            var degerler = context.About.FirstOrDefault();
            return View(degerler);
        }

        [HttpPost]
        public ActionResult AboutIndex(About hakkımda)
        {
            var values = context.About.Find(hakkımda.AboutId);

            values.Title = hakkımda.Title;
            values.Description = hakkımda.Description;
            values.ImageUrl = hakkımda.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
    }
}