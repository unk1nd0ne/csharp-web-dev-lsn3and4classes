using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student student = new Student();
            student.name = "Brad";
            student.studentId = 13;
            student.numberOfCredits = 1;
            student.gpa = 4.0;

            Teacher instructor = new Teacher();
            instructor.firstName = "Michael";
            instructor.lastName = "Smith";
            instructor.subject = "C#";
            instructor.yearsTeaching = 5;

            Course lc101 = new Course();
            lc101.courseName = "Code Camp";
            lc101.courseID = "LC101";
            lc101.courseInstructor = instructor;
            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            lc101.courseRoster = studentList;

            Console.WriteLine($"Course: {lc101.courseName} Course ID: {lc101.courseID} Students: {lc101.courseRoster.Count}");
            Console.WriteLine($"Teacher: {lc101.courseInstructor.firstName} {lc101.courseInstructor.lastName} Subject: {lc101.courseInstructor.subject} Years Teaching: {lc101.courseInstructor.yearsTeaching}");
            foreach (Student person in lc101.courseRoster)
            {
                Console.WriteLine($"Student: {person.name} ID: {person.studentId} Credits: {person.numberOfCredits} GPA: {person.gpa}");
            }
        }
    }
}
