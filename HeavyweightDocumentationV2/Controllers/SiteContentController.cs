using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeavyweightDocumentationV2.Controllers
{
    public class SiteContentController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Project Information & Development Notes";


            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the creator with suggestions";

            return View();
        }
    }
}