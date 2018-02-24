using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWithFeatures.Features.Calculator
{
    public partial class CalculatorController : Controller
    {
        // GET: Calculator
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}