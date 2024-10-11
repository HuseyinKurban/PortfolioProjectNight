using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        DbMyPortfolioNightEntities context= new DbMyPortfolioNightEntities();
        public ActionResult Index()
        {
            var skills=context.Skills.ToList();

            ViewBag.SkillNames=skills.Select(x=>x.SkillsName).ToList();
            ViewBag.SkillRates=skills.Select(x=>x.Rate).ToList();

            return View();
        }
    }
}