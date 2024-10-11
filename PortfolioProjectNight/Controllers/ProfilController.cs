using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        DbMyPortfolioNightEntities context=new DbMyPortfolioNightEntities();

        public ActionResult ProfileIndex()
        {
            var degerler=context.Profile.FirstOrDefault();
            return View(degerler);
        }

        [HttpPost]
        public ActionResult ProfileIndex(Profile prof)
        {
            var values = context.Profile.Find(prof.ProfileId);

            values.Birtdate = prof.Birtdate;
            values.Email = prof.Email;
            values.Phone = prof.Phone;
            values.Github = prof.Github;
            values.Adress = prof.Adress;
            values.Title = prof.Title;
            values.Description = prof.Description;
            values.ImageUrl = prof.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("ProfileIndex");
        }
    }
}