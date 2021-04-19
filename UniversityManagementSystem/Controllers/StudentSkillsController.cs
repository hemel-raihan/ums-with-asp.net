using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.DataAccess;

namespace UniversityManagementSystem.Controllers
{
    public class StudentSkillsController : Controller
    {
        // GET: StudentSkills
        UniversityManagementContext1 context = new UniversityManagementContext1();
        public ActionResult Index(int id)
        {
           
            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        public ActionResult Index(skill skill, HttpPostedFileBase photo)
        {
            if (skill.title == null)
            {
                ViewData["title"] = "Please fill the title";
                return View();
            }
            if (skill.photo == null)
            {
                ViewData["photo"] = "Please upload any file";
                return View();
            }
            if (skill.title == null)
            {
                ViewData["descrip"] = "Please fill the description";
                return View();
            }

            string filename = Path.GetFileName(photo.FileName);
            string _filename = DateTime.Now.ToString("yymmssfff") + filename;
            string extension = Path.GetExtension(photo.FileName);
            string path = Path.Combine(Server.MapPath("~/Content/Upload/"), _filename);
            //string fullpath = Path.Combine(path, filename);
            skill.photo = "~/Content/Upload/" + _filename;
            if(extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
            {
                if(photo.ContentLength <= 100000)
                {
                    context.skills.Add(skill);
                    if(context.SaveChanges()>0)
                    {
                        photo.SaveAs(path);
                        ModelState.Clear();
                    }
                   
                }
                else
                {
                    ViewBag.msg = "not valid";
                }

            }
            //photo.SaveAs(fullpath);

            /* context.skills.Add(skill);
             context.SaveChanges();  //create the query*/
            //return RedirectToAction("Index", "Dashboard");
            return View();
            
        }

        public ActionResult studentskill()
        {
            return View(context.skills.ToList());
        }

        public ActionResult showskills(int id)
        {
            var show = context.skills.ToList().Where(x => x.uid == id);
            //ViewData["id"] = id;
            return View(show);
        }

        public ActionResult skillsedit(int id)
        {
            var skillToEdit = context.skills.Find(id);  //this "Find" is for only primary key variable

            return View(skillToEdit);
        }
        [HttpPost]
        public ActionResult skillsedit(int id, skill skill, HttpPostedFileBase photo)
        {
            skill.photoid = id;

            string filename = Path.GetFileName(photo.FileName);
            string _filename = DateTime.Now.ToString("yymmssfff") + filename;
            string extension = Path.GetExtension(photo.FileName);
            string path = Path.Combine(Server.MapPath("~/Content/Upload/"), _filename);
            //string fullpath = Path.Combine(path, filename);
            skill.photo = "~/Content/Upload/" + _filename;
            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
            {
                if (photo.ContentLength <= 100000)
                {
                    context.Entry(skill).State = EntityState.Modified;
                    if (context.SaveChanges() > 0)
                    {
                        photo.SaveAs(path);
                        ModelState.Clear();
                    }

                }
                else
                {
                    ViewBag.msg = "not valid";
                }
            }

                
            /*context.Entry(skill).State = EntityState.Modified;
            context.SaveChanges();  //create the query*/
            return RedirectToAction("Index","Dashboard");
        }

        public ActionResult skillsdelete(int id)
        {
            var skillToDelete = context.skills.Find(id);  //this "Find" is for only primary key variable

            return View(skillToDelete);
        }

        [HttpPost, ActionName("skillsDelete")]
        public ActionResult confirmdelete(int id, skill skill)
        {
            context.skills.Remove(context.skills.Find(id));
            context.SaveChanges();  //create the query
            return RedirectToAction("Index", "Dashboard");
        }

        public ActionResult skillsdetails(int id)
        {
            var skillsToDetails = context.skills.Find(id); 
            return View(skillsToDetails);
        }
    }
}