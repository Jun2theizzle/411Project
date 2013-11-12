using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeTime.Controllers
{
    public class CoursesController : Controller
    {
        //
        // GET: /Courses/

        public ActionResult Index(string searchString)
        {
            return View();
        }

    }
}
