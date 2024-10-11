using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        DbMyPortfolioNightEntities context=new DbMyPortfolioNightEntities();
        public ActionResult ServiceIndex()
        {
            var values = context.Service.ToList();
            return View(values);
        }

        public ActionResult DeleteService(int id)
        {
            var values = context.Service.Find(id);
            context.Service.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Service.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = context.Service.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var values = context.Service.Find(service.ServiceId);
            values.Title = service.Title;
            values.Description = service.Description;
            values.Icon = service.Icon;
            context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }
    }
}