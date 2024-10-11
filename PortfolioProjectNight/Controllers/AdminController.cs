using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class AdminController : Controller
    {
        DbMyPortfolioNightEntities context= new DbMyPortfolioNightEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSideBar()
        {
            ViewBag.ProfilePhoto=context.Profile.Select(x=>x.ImageUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

     

    }
}