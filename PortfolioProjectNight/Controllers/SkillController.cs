using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class SkillController : Controller
    {
       DbMyPortfolioNightEntities context=new DbMyPortfolioNightEntities();

        public ActionResult SkillList(int sayfa=1)
        {
            var values=context.Skills.ToList().ToPagedList(sayfa,5);
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skills skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Update(Skills p1)
        {
            var yetenek = context.Skills.Find(p1.SkillsId);
            yetenek.SkillsName = p1.SkillsName;
            yetenek.Rate = p1.Rate;
            yetenek.Icon = p1.Icon;
            yetenek.Status = p1.Status;
            context.SaveChanges();
            return RedirectToAction("SkillList");

        }

    }
}