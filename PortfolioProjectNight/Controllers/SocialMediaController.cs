using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia,
        DbMyPortfolioNightEntities context= new DbMyPortfolioNightEntities();
        public ActionResult SocialMediaList()
        {
            var degerler=context.SocialMedia.ToList();
            return View(degerler);
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedia.Find(id);
            context.SocialMedia.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia sm)
        {
            context.SocialMedia.Add(sm);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult UpdatSocialMedia(int id)
        {
            var values = context.SocialMedia.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdatSocialMedia(SocialMedia sm)
        {
            var values = context.SocialMedia.Find(sm.SocialMediaId);
            values.Title = sm.Title;
            values.Icon = sm.Icon;
            values.Status = sm.Status;
            values.Url = sm.Url;
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}