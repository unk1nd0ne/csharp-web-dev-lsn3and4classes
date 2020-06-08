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
        private int Credits;
        private List<Student> CourseRoster = new List<Student>();

        
        public string courseName { get; set; }
        public string courseID { get; set; }
        public Teacher courseInstructor { get; set; }
        public List<Student> courseRoster { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   CourseName == course.CourseName &&
                   CourseID == course.CourseID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CourseName, CourseID);
        }

        public override string ToString()
        {
            return CourseName + " (Course ID: " + CourseID + ", Credits: " + Credits + ")";
        }
    }
}
