using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWithFeatures.Areas.Area1.Features.Home
{
    public partial class HomeController : Controller
    {
        // GET: Area1/Home
        public virtual ActionResult Index()
        {
            var doesNotWork = Views.Index;
            return View();
        }
    }
}