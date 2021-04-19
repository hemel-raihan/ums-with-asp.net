using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class LibraryController : Controller
    {
        UniversityManagementContext1 context = new UniversityManagementContext1();
        // GET: Library
        public ActionResult Index(int id)
        {
            Session["uid"] = id;
            return View(context.libraries.ToList());
        }

        public ActionResult bookdetails(int id)
        {
            var bookToDetails = context.libraries.Find(id);
            return View(bookToDetails);
        }

        public ActionResult borrow(int id)
        {
            var borrow = context.libraries.Find(id);
            return View(borrow);
        }
        [HttpPost]
        public ActionResult borrow(int id, bookborrow borow)
        {
            if (borow.bdate == null)
            {
                ViewData["bdate"] = "Please fill the borrow Date";
                return View();
            }

            if (borow.rdate == null)
            {
                ViewData["rdate"] = "Please fill the Return Date";
                return View();
            }

            context.bookborrows.Add(borow);
                context.SaveChanges();  //create the query
                ViewData["msg"] = "Order Successfully done";
                return RedirectToAction("Index", "Dashboard");
            
        }

        public ActionResult available()
        {
            var list = context.libraries.OrderByDescending(x => x.available).Take(3).ToList();
            return View(list);
        }

        public ActionResult showborrow(int id)
        {
            var show = context.bookborrows.ToList().Where(x => x.sid == id);
            return View(show);
        }
    }
}
