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
            
            
            //return View(new MenuManagerContext().Chains.ToList());
            return View(db.Courses.ToList());
        }
        
        [ActionName("loadcourseinfo")]
        [HttpGet]
        public ActionResult LoadCourseInfo(int ID)
        {
           
            var CourseInfo = (from _Course in db.Courses
                              where _Course.ID == ID
                              select _Course).FirstOrDefault();
            var Lectures = (from _Lecture in db.Lectures
                            where _Lecture.CourseID == ID
                            select _Lecture).ToArray<Lecture>();
            CourseInfo.Lectures = Lectures;

            var StudentIDs = (from _Course in db.Courses
                              where _Course.ID == ID
                              select _Course.StudentIDs).FirstOrDefault();
            CourseInfo.StudentIDs = StudentIDs;
            return Json(CourseInfo, JsonRequestBehavior.AllowGet);
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
