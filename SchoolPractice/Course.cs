using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private string CourseName;
        private string CourseID;
        private Teacher CourseInstructor;
        private List<Student> CourseRoster = new List<Student>();

        
        public string courseName { get; set; }
        public string courseID { get; set; }
        public Teacher courseInstructor { get; set; }
        public List<Student> courseRoster { get; set; } 
    }
}
