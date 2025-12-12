using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    class CStudent
    {
        private string name;
        private int age;
        private double gpa;

        public string Name
        { get { return name; }
          set { name = value; }
        }
        public int Age
        { get { return age; }
          set { age = value; }
        }
        public double Gpa
        { get { return gpa; }
          set { gpa = value; }
        }
        public CStudent()
        {
            //Initialize all the values to default
            name = " ";
            age = 0;
            gpa = 0;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, AP Score: {gpa:F2}");
            //Console.WriteLine($"Name: {name}, Age: {age}, AP Score: {gpa.ToString("0.00")}"); THE SAME AS THE ABOVE
        }
    }
}
