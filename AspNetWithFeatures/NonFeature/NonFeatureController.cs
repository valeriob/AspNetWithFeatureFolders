using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWithFeatures.NonFeature
{
    public class NonFeatureController : Controller
    {
        // GET: NonFeature
        public ActionResult Index()
        {
            return View();
        }
    }
}