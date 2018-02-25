using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWithFeatures.Areas.Area1.Uc1
{
    public partial class Uc1Controller : Controller
    {
        // GET: Area1/Home
        public virtual ActionResult Index()
        {
            var works = Views.Index;
            return View();
        }
    }
}