using SchoolManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (var context = new SchoolContext())
            {
                List<Grade> grades = new List<Grade>() {
                    new Grade(){ Name = "Grade A"},
                    new Grade(){ Name = "Grade A"}
                };

                context.Grades.AddRange(grades);
                context.SaveChanges();
            }

            return View();
        }
    }
}
