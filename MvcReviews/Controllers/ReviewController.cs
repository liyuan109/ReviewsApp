﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcReviews.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Review()
        {
            ViewBag.Message = "Your review page.";
            return View();
        }
    }
}