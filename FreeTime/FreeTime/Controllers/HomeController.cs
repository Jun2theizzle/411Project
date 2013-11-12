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
        private ClassCloudContext db = new ClassCloudContext();
        public ActionResult Index()
        {
            
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //return View(new MenuManagerContext().Chains.ToList());
            return View(db.Courses.ToList());
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

        public ActionResult Search(string searchString)
        {
            var courses = from m in new ClassCloudContext().Courses
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(s => s.Name.Contains(searchString));
            } 
            return View(courses);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course newCourse)
        {

            if (ModelState.IsValid)
            {
                db.Courses.Add(newCourse);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newCourse);
            }
        }
    }
}
