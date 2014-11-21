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
            if (User.Identity.GetUserId() != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("UnregisteredIndex");
            }
        }
        public ActionResult UnregisteredIndex()
        {
            //comment
            if (User.Identity.GetUserId() != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}