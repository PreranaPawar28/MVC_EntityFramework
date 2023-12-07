using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentEntites.Models;

namespace StudentEntites.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentCourseContext cs = new StudentCourseContext();
            List<Course> MyCourse = cs.Courses.ToList();
            return View(MyCourse);
        }
        public ActionResult StudentName(int Id)
        {
            StudentCourseContext cs = new StudentCourseContext();
            List<Student> students = cs.Students.Where(s => s.CourseId == Id).ToList();
            return View(students);
        }
    }
}