using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Student
    {
        private List<Student> _lst = new List<Student>();
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public String Semester { get; set; }

        public List<Student> GetAllStudent()
        {
            _lst.Add(new Student { StudentId = 100, StudentName = "Ahmed Khan", Semester = "V" });
            _lst.Add(new Student { StudentId = 101, StudentName = "Noman Khan", Semester = "V" });
            _lst.Add(new Student { StudentId = 102, StudentName = "Kamran Khan", Semester = "V" });

            return _lst;
        }
    }
}