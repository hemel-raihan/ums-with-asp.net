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

        public ActionResult courses(int id)
        {
            Session["uid"] = id;
            return View(context.courses.ToList());
        }

        public ActionResult coursedetails(int id)
        {
            var courseToDetails = context.courses.Find(id);
            return View(courseToDetails);
        }

        public ActionResult enroll(int id)
        {
            var enroll = context.courses.Find(id);
            return View(enroll);
        }

        [HttpPost]
        public ActionResult enroll(enroll enroll)
        {
            context.enrolls.Add(enroll);
            context.SaveChanges();  //create the query
            ViewData["msg"] = "Order Successfully done";
            return RedirectToAction("Index","Dashboard");
        }

        public ActionResult topcourse()
        {
            var list = context.courses.OrderByDescending(x => x.cprice).Take(3).ToList();
            return View(list);
        }
    }
}