using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        DbMyPortfolioNightEntities context=new DbMyPortfolioNightEntities();
        public ActionResult Index()
        {
          
            ViewBag.MessageCount = context.Contact.Count();
            ViewBag.EducationCount = context.Education.Count();
            ViewBag.ExperienceCount = context.Experience.Count();
            ViewBag.ServiceCount = context.Service.Count();
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.SocialMediaCount = context.SocialMedia.Count();
            ViewBag.WorkCount = context.Work.Count();


            return View();
            
        }
    }
}