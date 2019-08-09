﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReReView.DAL;

namespace ReReView.Controllers
{
    public class HomeController : Controller
    {
        private ReReViewContext db = new ReReViewContext();

        public ActionResult Index()
        {
            var model = new RankandrecentViewModel();
            model.Rankrestuarants = (from r in db.Restuarants orderby r.star descending select r).Take(4); ;
            model.Recentreviews = (from r in db.Reviews orderby r.reviewID descending select r).Take(4);


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}