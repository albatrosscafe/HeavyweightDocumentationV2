using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace HeavyweightDocumentationV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //comment
            if (User.Identity.GetUserId() != null)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Home()
        {
            if (User.Identity.GetUserId() != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}