using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class PhotoorderController : Controller
    {
        UniversityManagementContext1 context = new UniversityManagementContext1();
        // GET: Photoorder
        public ActionResult Index(int id)
        {
            var skillsToDetails = context.skills.Find(id);
            return View(skillsToDetails);
        }

        [HttpPost]
        public ActionResult Index(photoorder order)
        {
            context.photoorders.Add(order);
            context.SaveChanges();  //create the query
            ViewData["msg"] = "Order Successfully done";
            return RedirectToAction("studentskill", "studentskills");
        }

        public ActionResult showorder(int id)
        {
            var show = context.photoorders.ToList().Where(x => x.ownerid == id);
            return View(show);
        }
    }
}