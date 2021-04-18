using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        UniversityManagementContext1 context = new UniversityManagementContext1();
        // GET: Dashboard
        public ActionResult Index()
        {
            if(Session["name"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            var some = context.users.ToList().Where(x => x.email == Session["name"].ToString());
           // ViewData["student"] = context.students.ToList().Where(x => x.uid == Session["name"].ToString());
            //var categoryToEdit = context.users.Where(x => x.email == Session["name"]).FirstOrDefault();
            return View(some);
        }
    }
}