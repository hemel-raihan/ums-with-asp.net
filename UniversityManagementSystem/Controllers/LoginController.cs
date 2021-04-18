using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UniversityManagementContext1 context = new UniversityManagementContext1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user user)
        {
           var student = context.users.Where(x => x.email == user.email && x.password == user.password).Count();
            if(student > 0 )
            {
               // ViewData["name"] = user.email;
               
                
                Session["name"] = user.email;
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                ViewData["error"] = "Please Correct the email or password";
                return View();
            }
            
           
        }
      
      /*  public ActionResult Dashboard(user log)
        {
            ViewData["email"] = Session["name"];
            var categoryToEdit = context.users.Where(x => x.email == ViewData["email"]);
            //var categoryToEdit = context.book_borrows.Where(x => x.book_name == "hemel").FirstOrDefault;
            //var categoryToEdit = context.users.Find();
            //return View(context.book_borrows.ToList());
            // return View(context.users.ToList());
            return View(categoryToEdit);

        }*/

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index");
        }

    }
}