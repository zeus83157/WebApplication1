using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult MainPageA()
        {
            return View();
        }

        public ActionResult MainPageB()
        {
            return View();
        }
    }
}