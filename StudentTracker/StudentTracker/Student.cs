using System;

namespace StudentTracker
{
    public class Student
    {
        // Data fields
        private string name;
        private int age;
        private double gpa;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        // Default constructor
        public Student()
        {
            name = "";
            age = 0;
            gpa = 0;
        }

        // Display Method
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, AP Score: {gpa:F2}");
        }
    }
}