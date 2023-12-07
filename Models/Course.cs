using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEntites.Models
{
    [Table("tblCourse")]
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}