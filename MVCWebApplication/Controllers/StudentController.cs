using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student
        [HttpPost]
        public ActionResult Create(Student student)
        {
            ViewBag.Name = student.Name;
            ViewBag.Mobile = student.Mobile;
            ViewBag.Address = student.Address;
            return View("~/Views/Message.cshtml");
        }

        [HttpPost]
        public JsonResult GetStudentData(Student student)
        {
            student.Id = 1;

            return Json(student);
        }
    }
}