using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class StatisticsController : Controller
    {
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();

        public ActionResult Index()
        {
            ViewBag.totalMessageCount = context.Contact.Count();
            ViewBag.messageIsReadTrueCount = context.Contact.Where(x => x.IsRead == true).Count();
            ViewBag.messageIsReadFalseCount = context.Contact.Where(y => y.IsRead == false).Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.skillRateSum = context.Skills.Sum(x => x.Rate);
            ViewBag.skillRateAvg = context.Skills.Average(x => x.Rate);

            var maxRate = context.Skills.Max(x => x.Rate);
            ViewBag.maxRateSkillName = context.Skills.Where(x => x.Rate == maxRate).Select(y => y.SkillsName).FirstOrDefault();

            ViewBag.getMessageCountBySubjectReferances=context.Contact.Where(x=>x.Subject=="Referans").Count();

            ViewBag.getMessageCountByEmailContainHAndIsReadTrue=context.Contact.Where(x=>x.IsRead == true & x.Email.Contains("h")).Count();

            ViewBag.getSkillNameByRate90=context.Skills.Where(x=> x.Rate ==90).Select(y=>y.SkillsName).FirstOrDefault();

            return View();
        }
    }
}