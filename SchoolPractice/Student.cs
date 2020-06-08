using System;
using System.Runtime.CompilerServices;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double totalQualityScore = (this.Gpa * this.NumberOfCredits) + (grade * courseCredits);
            this.NumberOfCredits += courseCredits;
            this.Gpa = totalQualityScore / this.NumberOfCredits;

        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits < 30)
            {
                return "Freshman";
            }
            else if (this.NumberOfCredits < 60)
            {
                return "Sophmore";
            }
            else if (this.NumberOfCredits < 90)
            {
                return "Junior";
            }
            else 
            {
                return "Senior";
            
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   studentId == student.studentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, studentId);
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }
    }
