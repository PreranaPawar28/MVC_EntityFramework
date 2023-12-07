using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEntites.Models
{
    [Table("tblStudent")]
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public int CourseId { get; set; }
    }
}