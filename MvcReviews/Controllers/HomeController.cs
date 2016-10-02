using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcReviews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Discussion()
        {
            ViewBag.Message = "Your discussion page.";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Your feedback page.";

            return View();
        }
    }
}