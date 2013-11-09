using FreeTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeTime.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //hey
            int x  = 5;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //return View(new MenuManagerContext().Chains.ToList());
            return View(new ClassCloudContext().Courses.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Chat()
        {
            ViewBag.Message = "Your chat page.";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your Profile Here";
            return View();

        }
    }
}
