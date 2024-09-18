using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Inbox()
        {
            return View();
        }
    }
}