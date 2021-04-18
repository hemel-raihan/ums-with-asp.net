using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class CourseregController : Controller
    {
        UniversityManagementContext1 context = new UniversityManagementContext1();
        // GET: Coursereg
        [HttpGet]
        public ActionResult Index(int id)
        {
           // ViewData["course"] = context.enrolls.ToList().Where(x => x.s_id == id);
            var show = context.enrolls.ToList().Where(x => x.sid == id);
            return View(show);
        }
        [HttpGet]
        public ActionResult Faculty(int id)
        {
            
            var show = context.teachers.ToList().Where(x => x.teacherid == id);
            return View(show);
        }
    }
}