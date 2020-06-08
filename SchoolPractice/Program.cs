using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student student = new Student("Brad", 13, 1, 4.0);
            
            Teacher instructor = new Teacher();
            instructor.FirstName = "Michael";
            instructor.LastName = "Smith";
            instructor.Subject = "C#";
            instructor.YearsTeaching = 5;

            Course lc101 = new Course();
            lc101.courseName = "Code Camp";
            lc101.courseID = "LC101";
            lc101.courseInstructor = instructor;
            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            lc101.courseRoster = studentList;

            Console.WriteLine($"Course: {lc101.courseName} Course ID: {lc101.courseID} Students: {lc101.courseRoster.Count}");
            Console.WriteLine($"Teacher: {lc101.courseInstructor.FirstName} {lc101.courseInstructor.LastName} Subject: {lc101.courseInstructor.Subject} Years Teaching: {lc101.courseInstructor.YearsTeaching}");
            foreach (Student person in lc101.courseRoster)
            {
                Console.WriteLine($"Student: {person.Name} Credits: {person.NumberOfCredits} GPA: {person.Gpa}");
            }
        }
    }
}
